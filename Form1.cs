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
        public bool isdrawing;
        public Image sourceimage;
        public bool isfirst;
        public bool isshowback;
        public Form1()
        {
            InitializeComponent();
            sourceimage = Properties.Resources._1;
            l_size.Text = "预览比例(" + (pBmainview.Height * 1.0 / pBmainview.Width).ToString("N2") + ")可能与原图(" + (sourceimage.Height * 1.0 / sourceimage.Width).ToString("N2") + ")不一致\n但不影响输出情况(如何调整比例？拉伸窗口！)";

            isfirst = true;
        }

        private void btn_loadbase_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "Png(*.png)|*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourceimage = Image.FromFile(dialog.FileName);
                RefreshView();
                l_xyplus.Text = sourceimage.Width + "," + sourceimage.Height;
            }
        }

        private void RefreshView()
        {
            Bitmap tempimg = new Bitmap(sourceimage);
            tb_shouldlike.Text = " ";
            foreach (DataGridViewRow row in dgv_boxesdata.Rows)
            {
                drawpic("("+row.Cells["boxname"].Value + ")the quick brown fox jumps over a lazy dog.the quick brown fox jumps over a lazy dog.the quick brown fox jumps over a lazy dog.", new Rectangle(int.Parse(row.Cells["rectx1"].Value.ToString()), int.Parse(row.Cells["recty1"].Value.ToString()), int.Parse(row.Cells["width"].Value.ToString()), int.Parse(row.Cells["height"].Value.ToString())), row.Cells["font"].Value.ToString(), float.Parse(row.Cells["fontsize"].Value.ToString()), tempimg, row.Cells["color"].Style.BackColor,true, int.Parse(row.Cells["flag"].Value.ToString()));
                tb_shouldlike.Text += "'" +row.Cells["boxname"].Value.ToString() + "',";

            }
            tb_shouldlike.Text = tb_shouldlike.Text.Substring(0, tb_shouldlike.Text.Length - 1);
            pBmainview.Image = tempimg;
            //tempimg.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void btn_addbox_Click(object sender, EventArgs e)
        {
            if (!islegal(tb_rectx1.Text) || !islegal(tb_recty1.Text) || !islegal(tb_width.Text) || !islegal(tb_height.Text) || !islegal(tb_fontsize.Text))
            {
                MessageBox.Show("原点、宽长或字体大小值必须是整数");
                return;

            }

            int index = dgv_boxesdata.Rows.Count;
            int flagint;
            dgv_boxesdata.Rows.Add();
            dgv_boxesdata.Rows[index].HeaderCell.Value = index + 1;
            dgv_boxesdata.Rows[index].Cells["boxname"].Value = tb_boxname.Text;
            dgv_boxesdata.Rows[index].Cells["rectx1"].Value = tb_rectx1.Text;
            dgv_boxesdata.Rows[index].Cells["recty1"].Value = tb_recty1.Text;
            dgv_boxesdata.Rows[index].Cells["width"].Value = tb_width.Text;
            dgv_boxesdata.Rows[index].Cells["height"].Value = tb_height.Text;
            dgv_boxesdata.Rows[index].Cells["font"].Value = cb_font.Text;
            dgv_boxesdata.Rows[index].Cells["fontsize"].Value = tb_fontsize.Text;
            dgv_boxesdata.Rows[index].Cells["color"].Style.BackColor = colorshow.BackColor;

            if (cb_flag.Text == "居左0")
                flagint = 0;
            else if (cb_flag.Text == "居右1")
                flagint = 1;
            else if (cb_flag.Text == "竖左2")
                flagint = 2;
            else if (cb_flag.Text == "竖右3")
                flagint = 3;
            else
                flagint = 4096;
            dgv_boxesdata.Rows[index].Cells["flag"].Value = flagint;
            RefreshView();
        }

        private void drawpic(string text,Rectangle rectangle,string fontname,float fontsize,Image drawimage,Color color,bool drawback,int sfflag)
        {
            Font font = new Font(fontname,fontsize);
            StringFormat sf = new StringFormat((StringFormatFlags)sfflag);
            Brush fontbrush = new SolidBrush(color);
            Brush backbrush = new SolidBrush(Color.FromArgb(100,255-color.R,255-color.G,255-color.B));
            Graphics g = Graphics.FromImage(drawimage);
            if (drawback&&isshowback)
                g.FillRectangle(backbrush,rectangle);
            g.DrawString(text, font, fontbrush, rectangle, sf);
            g.Dispose();

        }

        private void dgv_boxesdata_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dgv_boxesdata_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            RefreshView();
        }

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

        private void btn_choosefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "文本文档(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = dialog.FileName;
                Properties.Settings.Default.inputtxtdir = filePath;
                Properties.Settings.Default.Save();
                tb_textdir.Text = filePath;


            }
        }

        private void btn_startdraw_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(drawprocess));
            btn_startdraw.Enabled = false;
            t1.IsBackground=true;
            t1.Start();
        }

        public void drawprocess()
        {
            int lineid = 0;
            foreach (string str in System.IO.File.ReadAllLines(Properties.Settings.Default.inputtxtdir, Encoding.UTF8))
            {
                lineid++;
                Bitmap tempimg = new Bitmap(sourceimage);
                List<string> drawlist = new List<string>(str.Split(','));
                if (drawlist.Count == dgv_boxesdata.Rows.Count)
                {
                    foreach (DataGridViewRow row in dgv_boxesdata.Rows)
                    {
                        drawpic(drawlist[row.Index], new Rectangle(int.Parse(row.Cells["rectx1"].Value.ToString()), int.Parse(row.Cells["recty1"].Value.ToString()), int.Parse(row.Cells["width"].Value.ToString()), int.Parse(row.Cells["height"].Value.ToString())), row.Cells["font"].Value.ToString(), float.Parse(row.Cells["fontsize"].Value.ToString()), tempimg, row.Cells["color"].Style.BackColor, false, (int)row.Cells["flag"].Value);

                    }
                    tempimg.Save(Properties.Settings.Default.savefolder + drawlist[0] + ".png");

                }
                else
                {
                    MessageBox.Show("在绘制：" + lineid + "行 时出现 文本框数(" + dgv_boxesdata.Rows.Count + ") 与行分隔 字段数(" + drawlist.Count + ") 不同的错误，已退出绘制。");
                    btn_startdraw.Enabled = true;
                    break;
                }
            }

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

        //使用变量而不是输入框的内容，防止用户自己修改输入框导致程序崩溃
        int currentX, currentY;


        private void pBmainview_MouseDown(object sender, MouseEventArgs e)
        {
            double wd = pBmainview.Width;
            double ht = pBmainview.Height;
            int x = (int)(sourceimage.Width * (e.X / wd));
            int y = (int)(sourceimage.Height * (e.Y / ht));
            if (isfirst)
            {
                currentX = x;
                currentY = y;

                tb_rectx1.Text = x.ToString();
                tb_recty1.Text = y.ToString();
                isfirst = false;
            }
            else
            {
                //对原来的x和现在的x重排序，小的就是新的x，大的用于计算width，这样可以实现点击任意位置都能定位
                isfirst = true;

                tb_rectx1.Text = currentX > x ? x.ToString() : currentX.ToString();
                tb_recty1.Text = currentY > y ? y.ToString() : currentY.ToString();
                tb_width.Text = Math.Abs(currentX - x).ToString();
                tb_height.Text = Math.Abs(currentY - y).ToString();
            }
        }

        private void dgv_boxesdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_boxesdata.CurrentCell == null) return;
            dgv_boxesdata.Rows.Remove(dgv_boxesdata.CurrentRow);
            RefreshView();
        }

        private void dgv_boxesdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_boxesdata.CurrentCell == null) return;
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
            if(isshowback)
            {
                isshowback = false;
                RefreshView();
            }
            else
            {
                isshowback = true;
                RefreshView();
            }
        }

        private void pBmainview_MouseMove(object sender, MouseEventArgs e)
        {
            double wd = pBmainview.Width;
            double ht = pBmainview.Height;
            int x = (int)(sourceimage.Width * (e.X / wd));
            int y = (int)(sourceimage.Height * (e.Y / ht));
            l_pos.Text = "truepixel(" + x + "," + y + ")";
        }

        private void pBmainview_MouseLeave(object sender, EventArgs e)
        {
            l_pos.Text = "truepixel(0,0)";
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            /*
            Bitmap tempimg = new Bitmap(sourceimage);
            Brush fontbrush = new SolidBrush(Color.Red);
            Graphics g = Graphics.FromImage(drawimage);
                g.FillRectangle(backbrush, rectangle);
            g.DrawString(text, font, fontbrush, rectangle, sf);
            g.Dispose();
            */
            
            if(sourceimage != null)
                l_size.Text = "预览比例(" + (pBmainview.Height * 1.0 / pBmainview.Width).ToString("N2") + ")可能与原图(" + (sourceimage.Height * 1.0 / sourceimage.Width).ToString("N2") + ")不一致\n但不影响输出情况(如何调整比例？拉伸窗口！)";
            
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
            sfd.Filter = "文本框集合TextboxSet（*.tbs）|*.tbs";
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
                    sw.WriteLine(row.Cells["boxname"].Value + ","+ row.Cells["rectx1"].Value + "," + row.Cells["recty1"].Value + "," + row.Cells["width"].Value + "," + row.Cells["height"].Value + "," + row.Cells["font"].Value + "," + row.Cells["fontsize"].Value + "," + row.Cells["color"].Style.BackColor.ToArgb().ToString("X8") + "," + row.Cells["flag"].Value);
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
            dialog.Filter = "文本框集合TextboxSet（*.tbs）|*.tbs";
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
                    if (textboxrow.Count == 9)
                    {
                        dgv_boxesdata.Rows.Add();
                        dgv_boxesdata.Rows[readingline - 1].Cells["boxname"].Value =textboxrow[0];
                        dgv_boxesdata.Rows[readingline - 1].Cells["rectx1"].Value=textboxrow[1];
                        dgv_boxesdata.Rows[readingline - 1].Cells["recty1"].Value= textboxrow[2];
                        dgv_boxesdata.Rows[readingline - 1].Cells["width"].Value = textboxrow[3];
                        dgv_boxesdata.Rows[readingline - 1].Cells["height"].Value = textboxrow[4];
                        dgv_boxesdata.Rows[readingline - 1].Cells["font"].Value = textboxrow[5];
                        dgv_boxesdata.Rows[readingline - 1].Cells["fontsize"].Value = textboxrow[6];
                        dgv_boxesdata.Rows[readingline - 1].Cells["color"].Style.BackColor =  ColorTranslator.FromHtml("#"+textboxrow[7]);
                        dgv_boxesdata.Rows[readingline - 1].Cells["flag"].Value = textboxrow[8];

                    }
                    else
                    {

                        MessageBox.Show("载入错误:行"+readingline);
                        break;
                    }

                }
                dgv_boxesdata.Refresh();
                RefreshView();


            }

        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            int side;
            if (sourceimage.Width > sourceimage.Height)
            {
                side = sourceimage.Height;
            }
            else
                side = sourceimage.Width;
            Bitmap tempimg = new Bitmap(sourceimage);
            Graphics g = Graphics.FromImage(tempimg);
            Brush br = new SolidBrush(Color.FromArgb(100,255,200,0));
            Brush fontbrush = new SolidBrush(Color.Red);
            Font font = new Font("黑体", 50);
            StringFormat sf = new StringFormat((StringFormatFlags)0);
            g.FillRectangle(br, new Rectangle(0, 0, side, side));
            g.FillRectangle(br, new Rectangle(5, 5, side-5, side-5));
            g.DrawString("我是个正方形,如果看起来不像,调整窗口大小直到我看上去像正方形，或者你也可以对照下面的预览比例和实际比例进行调整", font, fontbrush, new Rectangle(5, 5, side - 5, side - 5), sf);
            pBmainview.Image=tempimg;


        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            RefreshView();
        }
    }
}
