using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace CardEditor
{
    public partial class Form1 : Form
    {
        //Stopwatch Stopwatch= new Stopwatch();//花里胡哨的的选择框alpha周期缓动（bushi
        public bool Isdrawing;
        public Image SourceImage;
        //public bool IsFirst;//换拖动选取了
        public bool IsShowBack;
        private System.Drawing.Text.InstalledFontCollection ObjFont = new System.Drawing.Text.InstalledFontCollection();
        int Last_X , Last_Y = 0;//用于存储光标在预览中映射的最终坐标
        int Down_X, Down_Y, Up_X, Up_Y = 0;//存储鼠标在预览中点击和抬起时映射的坐标
        bool IsMouseDown = false;
        bool IsResizing = false;//修复启动时窗体还未完全加载时调用l_size报错的问题

        public Form1()
        {
            //初始化设置
            InitializeComponent();
            SourceImage = Properties.Resources._1;
            l_size.Text = "预览比例(" + (pBmainview.Height * 1.0 / pBmainview.Width).ToString("N2") + ")可能与原图(" + (SourceImage.Height * 1.0 / SourceImage.Width).ToString("N2") + ")不一致\n但不影响输出情况(如何调整比例？拉伸窗口！)";
            if (Directory.Exists(Properties.Settings.Default.savefolder)) tb_outdir.Text = Properties.Settings.Default.savefolder;
            if (Directory.Exists(Properties.Settings.Default.srcpicdir)) tb_srcpicfolder.Text = Properties.Settings.Default.srcpicdir;
            if (File.Exists(Properties.Settings.Default.inputtxtdir)) tb_textdir.Text = Properties.Settings.Default.inputtxtdir;
            //允许跨线程传参
            CheckForIllegalCrossThreadCalls = false;

            //IsFirst = true;

            //读取系统字库初始化字体选择下拉框
            foreach(System.Drawing.FontFamily i in ObjFont.Families)
            {
                cb_font.Items.Add(i.Name.ToString());
            }
            cb_font.SelectedIndex = 0;
            cb_picsrcfrom.SelectedIndex = 0;
            cb_flag.SelectedIndex = 0;
            //dgv_boxesdata.Columns["font"].DataPropertyName
        }

        private void btn_loadbase_Click(object sender, EventArgs e)
        {
            //加载底图函数
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择文件";
            dialog.Filter = "Png(*.png)|*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fileStream = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read);
                int byteLength = (int)fileStream.Length;
                byte[] fileBytes = new byte[byteLength];
                fileStream.Read(fileBytes, 0, byteLength);
                fileStream.Close();//关闭文件流，解除锁定

                SourceImage = Image.FromStream(new MemoryStream(fileBytes));//流转Image类
                //SourceImage = Image.FromFile(dialog.FileName);
                RefreshView();
                //标点底图右下角坐标
                l_xyplus.Text = SourceImage.Width + "," + SourceImage.Height;
            }
        }

        //刷新底图预览（&一行样例）函数
        private void RefreshView()
        {
            int rx1,rx2,ry1,ry2;
            Bitmap TempImg = new Bitmap(SourceImage);
            tb_shouldlike.Text = " ";
            foreach (DataGridViewRow row in dgv_boxesdata.Rows)
            {
                tb_shouldlike.Text += "'" +row.Cells["boxname"].Value.ToString() + "',";
                rx1 = int.Parse(row.Cells["rectx1"].Value.ToString());
                rx2 = int.Parse(row.Cells["rectx2"].Value.ToString());
                ry1 = int.Parse(row.Cells["recty1"].Value.ToString());
                ry2 = int.Parse(row.Cells["recty2"].Value.ToString());
                if (row.Cells["pic"].Value.ToString() == "仅文字无图")
                {
                    
                    string tfontname = "黑体";//默认字体
                    if (row.Cells["font"].Value != null)//判断防止引用空报错
                        tfontname = row.Cells["font"].Value.ToString();
                    DrawPic("(" + row.Cells["boxname"].Value + ")the quick brown fox jumps over a lazy dog.the quick brown fox jumps over a lazy dog.the quick brown fox jumps over a lazy dog.", new Rectangle(Math.Min(rx1, rx2), Math.Min(ry1, ry2), Math.Abs(rx2-rx1), Math.Abs(ry2-ry1)), tfontname, float.Parse(row.Cells["fontsize"].Value.ToString()), TempImg, row.Cells["color"].Style.BackColor, true, int.Parse(row.Cells["flag"].Value.ToString()), null);

                }
                else
                {
                    //针对图片框显示预览图（品红/绿）
                    if(IsShowBack) DrawPic(string.Empty, new Rectangle(Math.Min(rx1, rx2), Math.Min(ry1, ry2), Math.Abs(rx2 - rx1), Math.Abs(ry2 - ry1)), row.Cells["font"].Value.ToString(), float.Parse(row.Cells["fontsize"].Value.ToString()), TempImg, row.Cells["color"].Style.BackColor, false, int.Parse(row.Cells["flag"].Value.ToString()), Properties.Resources.defaultimg1);
                    else DrawPic(string.Empty, new Rectangle(Math.Min(rx1, rx2), Math.Min(ry1, ry2), Math.Abs(rx2 - rx1), Math.Abs(ry2 - ry1)), row.Cells["font"].Value.ToString(), float.Parse(row.Cells["fontsize"].Value.ToString()), TempImg, row.Cells["color"].Style.BackColor, false, int.Parse(row.Cells["flag"].Value.ToString()),null);

                }

            }
            tb_shouldlike.Text = tb_shouldlike.Text.Substring(0, tb_shouldlike.Text.Length - 1);//刷新一行预览
            pBmainview.Image = TempImg;
            //TempImg.Dispose();
        }


        //添加框函数
        private void btn_addbox_Click(object sender, EventArgs e)
        {
            //原点坐标+长宽确定矩形，已改为两点坐标确定矩形
            int index = dgv_boxesdata.Rows.Count;
            int Flagint;//用于判断对齐
            dgv_boxesdata.Rows.Add();
            dgv_boxesdata.Rows[index].HeaderCell.Value = index + 1;
            dgv_boxesdata.Rows[index].Cells["boxname"].Value = tb_boxname.Text;

            dgv_boxesdata.Rows[index].Cells["rectx1"].Value = nUD_rectx1.Value;
            dgv_boxesdata.Rows[index].Cells["recty1"].Value = nUD_recty1.Value;
            dgv_boxesdata.Rows[index].Cells["rectx2"].Value = nUD_rectx2.Value;
            dgv_boxesdata.Rows[index].Cells["recty2"].Value = nUD_recty2.Value;

            dgv_boxesdata.Rows[index].Cells["font"].Value = cb_font.Text;
            dgv_boxesdata.Rows[index].Cells["fontsize"].Value = nUD_fontsize.Value;
            dgv_boxesdata.Rows[index].Cells["color"].Style.BackColor = colorshow.BackColor;

            dgv_boxesdata.Rows[index].Cells["pic"].Value = cb_picsrcfrom.SelectedItem;
            if (cb_picsrcfrom.Text != "仅文字无图")
            {
                dgv_boxesdata.Rows[index].Cells["font"].Style.BackColor = Color.Gray;
                dgv_boxesdata.Rows[index].Cells["fontsize"].Style.BackColor = Color.Gray;
                dgv_boxesdata.Rows[index].Cells["flag"].Style.BackColor = Color.Gray;
                dgv_boxesdata.Rows[index].Cells["font"].Value = string.Empty;
                dgv_boxesdata.Rows[index].Cells["fontsize"].Value = 1;
                dgv_boxesdata.Rows[index].Cells["color"].Style.BackColor = Color.Black;

            }
            if (cb_flag.Text == "居左0")
                Flagint = 0;
            else if (cb_flag.Text == "居右1")
                Flagint = 1;
            else if (cb_flag.Text == "竖左2")
                Flagint = 2;
            else if (cb_flag.Text == "竖右3")
                Flagint = 3;
            else
                Flagint = 4096;
            dgv_boxesdata.Rows[index].Cells["flag"].Value = Flagint;
            RefreshView();
        }

        private void DrawPic(string text,Rectangle rectangle,string fontname,float fontsize,Image drawimage,Color color,bool drawback,int sfflag,Image img)
        {
            if (fontname == string.Empty) fontname = "黑体";
            Font font = new Font(fontname,fontsize);
            StringFormat sf = new StringFormat((StringFormatFlags)sfflag);
            Brush fontbrush = new SolidBrush(color);
            Brush backbrush = new SolidBrush(Color.FromArgb(100,255-color.R,255-color.G,255-color.B));
            Graphics g = Graphics.FromImage(drawimage);
            if (drawback&&IsShowBack)
                g.FillRectangle(backbrush,rectangle);
            if(img != null)
                g.DrawImage(img, rectangle);
            g.DrawString(text, font, fontbrush, rectangle, sf);
            g.Dispose();

        }

        private void dgv_boxesdata_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_boxesdata.Rows[e.RowIndex].Cells["pic"].Value.ToString() == "仅文字无图")
            {
                dgv_boxesdata.Rows[e.RowIndex].Cells["font"].Style.BackColor = Color.White;
                dgv_boxesdata.Rows[e.RowIndex].Cells["fontsize"].Style.BackColor = Color.White;
                dgv_boxesdata.Rows[e.RowIndex].Cells["flag"].Style.BackColor = Color.White;
            }
            else
            {
                dgv_boxesdata.Rows[e.RowIndex].Cells["font"].Style.BackColor = Color.Gray;
                dgv_boxesdata.Rows[e.RowIndex].Cells["fontsize"].Style.BackColor = Color.Gray;
                dgv_boxesdata.Rows[e.RowIndex].Cells["flag"].Style.BackColor = Color.Gray;

            }
            RefreshView();
        }

        //选择输出文件夹函数
        private void btn_choosefolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            dialog.SelectedPath = Properties.Settings.Default.savefolder;
            //dialog.RootFolder = Environment.SpecialFolder.Programs;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath + "\\";
                Properties.Settings.Default.savefolder = foldPath;
                Properties.Settings.Default.Save();
                tb_outdir.Text = foldPath;
            }
        }

        //选择输入参数函数
        private void btn_choosefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "有逗号分隔的文本文档(*.txt)|*.txt|逗号分隔文件(*.csv)|*.csv";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = dialog.FileName;
                Properties.Settings.Default.inputtxtdir = filePath;
                Properties.Settings.Default.Save();
                tb_textdir.Text = filePath;


            }
        }

        //开始绘制线程函数
        private void btn_startdraw_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(DrawProcess));
            btn_startdraw.Enabled = false;
            t1.IsBackground=true;
            t1.Start();
        }

        //绘制独立线程，防止程序假死
        public void DrawProcess()
        {

            int LineId = 0;
            int BoxId = 0;
            string Mode = string.Empty;
            string PicSrc = string.Empty;
            List<string> drawlist = null;
            string text = string.Empty;
            string FontName = string.Empty;
            float FontSize = 0;
            Color DrawColor= Color.White;
            int flag = 0;
            Rectangle myRectangle= new Rectangle(0,0,0,0);
            Image image;
            string e = Properties.Settings.Default.srcpicdir;
            if (!File.Exists(Properties.Settings.Default.inputtxtdir))
            {
                MessageBox.Show("没有文件输入!");
                btn_startdraw.Enabled = true;
                return;
            }
            try
            {
                foreach (string str in File.ReadAllLines(Properties.Settings.Default.inputtxtdir, Encoding.UTF8))
                {
                    int rx1, rx2, ry1, ry2;
                    LineId++;
                    Bitmap TempImg = new Bitmap(SourceImage);
                    drawlist = new List<string>(str.Split(','));
                    //if (drawlist.Count == dgv_boxesdata.Rows.Count)
                    //{
                    BoxId = 0;
                    foreach (DataGridViewRow row in dgv_boxesdata.Rows)
                    {
                        //原点坐标+长宽确定矩形，已改为两点坐标确定矩形
                        rx1 = int.Parse(row.Cells["rectx1"].Value.ToString());
                        rx2 = int.Parse(row.Cells["rectx2"].Value.ToString());
                        ry1 = int.Parse(row.Cells["recty1"].Value.ToString());
                        ry2 = int.Parse(row.Cells["recty2"].Value.ToString());

                        BoxId++;
                        myRectangle = new Rectangle(Math.Min(rx1, rx2), Math.Min(ry1, ry2), Math.Abs(rx2 - rx1), Math.Abs(ry2 - ry1));
                        FontName = row.Cells["font"].Value.ToString();
                        FontSize = float.Parse(row.Cells["fontsize"].Value.ToString());
                        DrawColor = row.Cells["color"].Style.BackColor;
                        flag = int.Parse(row.Cells["flag"].Value.ToString());
                        text = string.Empty;
                        if (row.Cells["pic"].Value.ToString() == "仅文字无图")
                        {
                            Mode = row.Cells["pic"].Value.ToString();
                            PicSrc = "no source";
                            text = drawlist[row.Index];
                            image = null;
                        }
                        else if (row.Cells["pic"].Value.ToString() == "从绝对路径")
                        {
                            Mode = row.Cells["pic"].Value.ToString();
                            PicSrc = drawlist[row.Index];
                            image = Image.FromFile(PicSrc);
                        }
                        else
                        {
                            if (!Directory.Exists(e))
                                e += "---<!'图片引用方式'选用'从相对路径'模式时不应不填写相对目录>";

                            Mode = row.Cells["pic"].Value.ToString();
                            PicSrc = Properties.Settings.Default.srcpicdir + drawlist[row.Index];
                            image = Image.FromFile(PicSrc);
                        }

                        DrawPic(text, myRectangle, FontName, FontSize, TempImg, DrawColor, false, flag, image);


                    }
                    TempImg.Save(Properties.Settings.Default.savefolder + drawlist[0] + ".png");
                    btn_startdraw.Enabled = true;



                }


            }

            catch (Exception ex)
            {
                string a = dgv_boxesdata.Rows.Count.ToString();
                string b = drawlist.Count.ToString();
                string c = Properties.Settings.Default.inputtxtdir;
                string d = PicSrc;
                if (dgv_boxesdata.Rows.Count != drawlist.Count)
                {
                    a += "---<!框数和分隔字段数不同>";
                    b += "---<!框数和分隔字段数不同>";
                }
                if (!File.Exists(c))
                    c += "---<!文件不存在>";
                if(!File.Exists(d))
                    d += "---<!文件不存在>";

                string errormessage = "出现绘制错误,已退出绘制！\n!!!!!!!(错误内容以---<!>显示)!!!!!!!\n======**======\n尝试绘制行:" + LineId + "\n尝试绘制文本框:" + BoxId + "\n文本框数:" + a + "\n行分隔字段数:" + b + "\n输出:" + Properties.Settings.Default.savefolder + "\n输入文件:" + c + "\n图像来源:\n模式:" + Mode + "\n相对路径:" + e + "\n完整路径:" + d + "\n======**======\n常见解决方案:\n检查输入文件和图像来源是否存在\n检查输入文件的尝试绘制行中分隔字段数是否与当前文本框数相同\n======**======\n高级错误信息，汇报请上传截图：" + ex;
                MessageBox.Show(errormessage);
                
            }
            btn_startdraw.Enabled = true;


        }

        private void colorshow_Click(object sender, EventArgs e)
        {
            ColorDialog colorDia = new ColorDialog();

            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                //获取所选择的颜色
                Color colorChoosed = colorDia.Color;
                //改变panel的背景色
                colorshow.BackColor = colorChoosed;

            }

        }

        public void pBmainview_DrawArea_get(object sender, MouseEventArgs e)
        {
            //Stopwatch.Start();
            IsMouseDown = true;
            Down_X = Last_X;
            Down_Y = Last_Y;
        }
        private void pBmainview_MouseUp(object sender, MouseEventArgs e)
        {
            //Stopwatch.Stop();
            //Stopwatch.Reset();
            IsMouseDown = false;
            Up_X = Last_X;
            Up_Y = Last_Y;
            RefreshView();

            nUD_rectx1.Value = Math.Min(Down_X, Up_X);
            nUD_recty1.Value = Math.Min(Down_Y, Up_Y);
            nUD_rectx2.Value = Math.Max(Down_X, Up_X);
            nUD_recty2.Value = Math.Max(Down_Y, Up_Y);
            
        }

        private void pBmainview_MouseMove(object sender, MouseEventArgs e)
        {
            
            double wd = pBmainview.Width;
            double ht = pBmainview.Height;
            Last_X = (int)(SourceImage.Width * (e.X / wd));
            Last_Y = (int)(SourceImage.Height * (e.Y / ht));
            l_pos.Text = "truepixel(" + Last_X + "," + Last_Y + ")";

            if (IsMouseDown)
            {
                Bitmap TempImg = new Bitmap(SourceImage);
                Graphics g = Graphics.FromImage(TempImg);
                //LDebugger.Text = ((int)Math.Abs((Math.Sin(Stopwatch.ElapsedMilliseconds * 0.001) * 100))).ToString();
                //Brush br = new SolidBrush(Color.FromArgb((int)(Math.Sin(Stopwatch.ElapsedMilliseconds * 0.001) * 25)+100, 255, 200, 0));
                Brush br = new SolidBrush(Color.FromArgb(100, 255, 200, 0));
                g.FillRectangle(br, new Rectangle(Math.Min(Down_X,Last_X), Math.Min(Down_Y,Last_Y),Math.Abs(Last_X-Down_X), Math.Abs(Last_Y -Down_Y)));
                pBmainview.Image = TempImg;

            }

        }
        /*private void pBmainview_MouseDown(object sender, MouseEventArgs e)
        {
            double wd = pBmainview.Width;
            double ht = pBmainview.Height;
            int x = (int)(SourceImage.Width * (e.X / wd));
            int y = (int)(SourceImage.Height * (e.Y / ht));
            if (IsFirst)
            {
                nUD_rectx1.Value = x;
                nUD_recty1.Value = y;
                //tb_rectx1.Text = x.ToString();
                //tb_recty1.Text = y.ToString();

                IsFirst = false;
            }
            else
            {
                int x1 = (int)nUD_rectx1.Value;
                int y1 = (int)nUD_recty1.Value;
                //int x1 = int.Parse(tb_rectx1.Text);
                //int y1 = int.Parse(tb_recty1.Text);
                if (x1 != null && x >= x1 && y1 != null && y >= y1)
                {
                    nUD_rectx2.Value = x - x1;
                    nUD_recty2.Value = y - y1;
                    //tb_width.Text = (x - x1).ToString();
                    //tb_height.Text = (y - y1).ToString();
                    IsFirst = true;
                }


            }
        }*/

        private void dgv_boxesdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_boxesdata.RowCount == 0)
                return;
            if(dgv_boxesdata.CurrentCell.ColumnIndex == 7)
            {
                ColorDialog colorDia = new ColorDialog();

                if (colorDia.ShowDialog() == DialogResult.OK)
                {
                    //获取所选择的颜色
                    Color colorChoosed = colorDia.Color;
                    //改变panel的背景色
                    dgv_boxesdata.CurrentCell.Style.BackColor = colorChoosed;
                    RefreshView();
                }

            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/POPCORNBOOM");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(IsShowBack)
            {
                IsShowBack = false;
                RefreshView();
            }
            else
            {
                IsShowBack = true;
                RefreshView();
            }
        }



        private void pBmainview_MouseLeave(object sender, EventArgs e)
        {
            l_pos.Text = "truepixel(0,0)";
        }



        public bool islegal(string validateString)
        {
            try
            {
                int.Parse(validateString);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btn_savecfg_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "框集合BoxSet（*.bs）|*.bs";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (dgv_boxesdata.RowCount == 0)
            {
                MessageBox.Show("集合为空！");
                return;
            }
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filename = sfd.FileName.ToString();
                StreamWriter sw = new StreamWriter(filename);
                foreach (DataGridViewRow row in dgv_boxesdata.Rows)
                {
                    sw.WriteLine(row.Cells["boxname"].Value + ","+ row.Cells["rectx1"].Value + "," + row.Cells["recty1"].Value + "," + row.Cells["rectx2"].Value + "," + row.Cells["recty2"].Value + "," + row.Cells["font"].Value + "," + row.Cells["fontsize"].Value + "," + row.Cells["color"].Style.BackColor.ToArgb().ToString("X8") + "," + row.Cells["flag"].Value +","+row.Cells["pic"].Value);
                }
                sw.Close();//关闭
                MessageBox.Show("保存成功");
            }
        }

        private void btn_loadcfg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择文件";
            dialog.Filter = "框集合BoxSet（*.bs,*.tbs）|*.bs;*.tbs";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dgv_boxesdata.Rows.Clear();
                dgv_boxesdata.Refresh();
                int readingline = 0;
                string filePath = dialog.FileName;
                foreach (string str in System.IO.File.ReadAllLines(filePath))
                {
                    readingline++;
                    List<string> textboxrow = new List<string>(str.Split(','));

                    if (textboxrow.Count == 10)
                    {
                        dgv_boxesdata.Rows.Add();
                        dgv_boxesdata.Rows[readingline - 1].Cells["boxname"].Value = textboxrow[0];
                        dgv_boxesdata.Rows[readingline - 1].Cells["rectx1"].Value = textboxrow[1];
                        dgv_boxesdata.Rows[readingline - 1].Cells["recty1"].Value = textboxrow[2];
                        dgv_boxesdata.Rows[readingline - 1].Cells["rectx2"].Value = textboxrow[3];
                        dgv_boxesdata.Rows[readingline - 1].Cells["recty2"].Value = textboxrow[4];
                        dgv_boxesdata.Rows[readingline - 1].Cells["font"].Value = textboxrow[5];
                        dgv_boxesdata.Rows[readingline - 1].Cells["fontsize"].Value = textboxrow[6];
                        dgv_boxesdata.Rows[readingline - 1].Cells["color"].Style.BackColor = ColorTranslator.FromHtml("#" + textboxrow[7]);
                        dgv_boxesdata.Rows[readingline - 1].Cells["flag"].Value = textboxrow[8];
                        dgv_boxesdata.Rows[readingline - 1].Cells["pic"].Value = textboxrow[9];
                        if (textboxrow[9] != "仅文字无图")
                        {
                            dgv_boxesdata.Rows[readingline - 1].Cells["font"].Style.BackColor = Color.Gray;
                            dgv_boxesdata.Rows[readingline - 1].Cells["fontsize"].Style.BackColor = Color.Gray;
                            dgv_boxesdata.Rows[readingline - 1].Cells["flag"].Style.BackColor = Color.Gray;

                        }

                    }
                    else
                    {

                        MessageBox.Show("载入错误:行" + readingline);
                        break;
                    }

                    

                }
                dgv_boxesdata.Refresh();
                RefreshView();


            }

        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }
        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            IsResizing = true;
            int side;
            if (SourceImage.Width > SourceImage.Height)
            {
                side = SourceImage.Height;
            }
            else
                side = SourceImage.Width;
            Bitmap TempImg = new Bitmap(SourceImage);
            Graphics g = Graphics.FromImage(TempImg);
            Brush br = new SolidBrush(Color.FromArgb(100,255,200,0));
            Brush fontbrush = new SolidBrush(Color.Red);
            Font font = new Font("黑体", 50);
            StringFormat sf = new StringFormat((StringFormatFlags)0);
            g.FillRectangle(br, new Rectangle(0, 0, side, side));
            g.FillRectangle(br, new Rectangle(5, 5, side-5, side-5));
            g.DrawString("我是个正方形,如果看起来不像,调整窗口大小直到我看上去像正方形，或者你也可以对照下面的预览比例和实际比例进行调整", font, fontbrush, new Rectangle(5, 5, side - 5, side - 5), sf);
            pBmainview.Image=TempImg;


        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            IsResizing = false;
            RefreshView();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Process.Start("https://popcornboom.github.io/contact/");
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dgv_boxesdata.CurrentRow == null) return;
            dgv_boxesdata.Rows.Remove(dgv_boxesdata.CurrentRow);
            RefreshView();
        }

        private void btn_moveup_Click(object sender, EventArgs e)
        {
            if (dgv_boxesdata.CurrentRow == null|| dgv_boxesdata.CurrentRow.Index <= 0) return;
            int index = dgv_boxesdata.CurrentRow.Index;
            DataGridViewRow dgvs = dgv_boxesdata.CurrentRow;

            //dgv_boxesdata.Rows[dgv_boxesdata.CurrentRow.Index-1].Cells
            try
            {

                DataGridViewRow dgvr = dgv_boxesdata.Rows[index - 1];//获取选中行的上一行
                dgv_boxesdata.Rows.RemoveAt(index - 1);//删除原选中行的上一行
                dgv_boxesdata.Rows.Insert((index), dgvr);//将选中行的上一行插入到选中行的后面

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            RefreshView();

        }

        private void pBmainview_Resize(object sender, EventArgs e)
        {
            if(IsResizing)
            l_size.Text = "预览比例(" + (pBmainview.Height * 1.0 / pBmainview.Width).ToString("N2") + ")可能与原图(" + (SourceImage.Height * 1.0 / SourceImage.Width).ToString("N2") + ")不一致\n但不影响输出情况(如何调整比例？拉伸窗口！)";

        }

        private void btn_opensavefolder_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.savefolder);
        }

        private void btn_movedown_Click(object sender, EventArgs e)
        {
            if (dgv_boxesdata.CurrentRow == null || dgv_boxesdata.CurrentRow.Index == dgv_boxesdata.RowCount-1) return;
            int index = dgv_boxesdata.CurrentRow.Index;
            DataGridViewRow dgvs = dgv_boxesdata.CurrentRow;

            //dgv_boxesdata.Rows[dgv_boxesdata.CurrentRow.Index-1].Cells
            try
            {

                DataGridViewRow dgvr = dgv_boxesdata.Rows[index+1];//获取选中行的下一行
                dgv_boxesdata.Rows.RemoveAt(index + 1);//删除原选中行的下一行
                dgv_boxesdata.Rows.Insert((index), dgvr);//将选中行的上一行插入到选中行的后面

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            RefreshView();

        }

        private void btn_choosepicfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            dialog.SelectedPath = Properties.Settings.Default.srcpicdir;
            //dialog.RootFolder = Environment.SpecialFolder.Programs;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath + "\\";
                Properties.Settings.Default.srcpicdir = foldPath;
                Properties.Settings.Default.Save();
                tb_srcpicfolder.Text = foldPath;
            }
        }

        private void cb_picsrcfrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_picsrcfrom.Text == "仅文字无图")
            {
                gb_text.Enabled = true;
                l_boxname.Text = "文本框名称";
                btn_addbox.Text = "新建文本框";
            }
            else
            {
                gb_text.Enabled = false;
                l_boxname.Text = "图片框名称";
                btn_addbox.Text = "新建图片框";

            }
        }

        private void btn_duplicate_Click(object sender, EventArgs e)
        {
            if (dgv_boxesdata.CurrentRow == null) return;
            dgv_boxesdata.Rows.Add();
            int id=0;
            int index = dgv_boxesdata.CurrentRow.Index;
            foreach (DataGridViewCell cell in dgv_boxesdata.CurrentRow.Cells)
            {
                if(id==7)
                    dgv_boxesdata.Rows[dgv_boxesdata.RowCount - 1].Cells[id].Style.BackColor = cell.Style.BackColor;
                dgv_boxesdata.Rows[dgv_boxesdata.RowCount - 1].Cells[id].Value = cell.Value;
                id++;
            }
            DataGridViewRow dgvs = dgv_boxesdata.CurrentRow;
            try
            {
                DataGridViewRow dgvr = dgv_boxesdata.Rows[dgv_boxesdata.RowCount - 1];
                dgv_boxesdata.Rows.RemoveAt(dgv_boxesdata.RowCount - 1);
                dgv_boxesdata.Rows.Insert((index), dgvr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            RefreshView();

        }
    }
}
