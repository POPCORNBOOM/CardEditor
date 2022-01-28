using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CardEditor.Properties;

// ReSharper disable PossibleNullReferenceException
// ReSharper disable LocalizableElement

namespace CardEditor
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Box> boxes = new BindingList<Box>();
        private int Down_X, Down_Y, Up_X, Up_Y; //存储鼠标在预览中点击和抬起时映射的坐标

        //Stopwatch Stopwatch= new Stopwatch();//花里胡哨的的选择框alpha周期缓动（bushi
        public bool Isdrawing;
        private bool IsMouseDown;

        private bool IsResizing; //修复启动时窗体还未完全加载时调用l_size报错的问题

        //public bool IsFirst;//换拖动选取了
        public bool IsShowBack;
        private int Last_X, Last_Y; //用于存储光标在预览中映射的最终坐标
        private readonly InstalledFontCollection ObjFont = new InstalledFontCollection();
        public Image SourceImage;

        public Form1()
        {
            //初始化设置
            InitializeComponent();
            SourceImage = Resources._1;
            l_size.Text = "预览比例(" + (pBmainview.Height * 1.0 / pBmainview.Width).ToString("N2") + ")可能与原图(" +
                          (SourceImage.Height * 1.0 / SourceImage.Width).ToString("N2") +
                          ")不一致\n但不影响输出情况(如何调整比例？拉伸窗口！)";
            if (Directory.Exists(Settings.Default.savefolder)) tb_outdir.Text = Settings.Default.savefolder;
            if (Directory.Exists(Settings.Default.srcpicdir)) tb_srcpicfolder.Text = Settings.Default.srcpicdir;
            if (File.Exists(Settings.Default.inputtxtdir)) tb_textdir.Text = Settings.Default.inputtxtdir;
            //允许跨线程传参
            CheckForIllegalCrossThreadCalls = false;

            //IsFirst = true;

            //读取系统字库初始化字体选择下拉框
            foreach (var i in ObjFont.Families) cb_font.Items.Add(i.Name);
            cb_font.SelectedIndex = 0;
            cb_picsrcfrom.SelectedIndex = 0;

            dgv_boxesdata.DataSource = boxes;
            dgv_boxesdata.Columns[nameof(Box.TextOnly)].Visible = false;

            var wrappedFlags = Enum.GetValues(typeof(TextAlign)).Cast<TextAlign>()
                .Select(ta => ta.WrapEnum()).Cast<object>().ToArray();
            var flagCol = (DataGridViewComboBoxColumn) dgv_boxesdata.Columns["flag"];
            flagCol.Items.AddRange(wrappedFlags);
            cb_flag.Items.AddRange(wrappedFlags);
            cb_flag.SelectedIndex = 0;
        }

        private void btn_loadbase_Click(object sender, EventArgs e)
        {
            //加载底图函数
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择文件";
            dialog.Filter = "Png(*.png)|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var fileStream = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    SourceImage = Image.FromStream(fileStream);
                }

                //SourceImage = Image.FromFile(dialog.FileName);
                RefreshView();
                //标点底图右下角坐标
                l_xyplus.Text = SourceImage.Width + "," + SourceImage.Height;
            }
        }

        //刷新底图预览（&一行样例）函数
        private void RefreshView()
        {
            var tempImg = new Bitmap(SourceImage);

            tb_shouldlike.Text = string.Join(",", boxes.Select(it => $"'{it.Name}'").ToArray()); //刷新一行预览

            foreach (var box in boxes)
                box.Draw(PlaceHolderText(box.Name), tempImg, IsShowBack);
            pBmainview.Image = tempImg;
        }

        private static string PlaceHolderText(string name)
        {
            return
                $"({name})the quick brown fox jumps over a lazy dog.the quick brown fox jumps over a lazy dog.the quick brown fox jumps over a lazy dog.";
        }


        //添加框函数
        private void btn_addbox_Click(object sender, EventArgs e)
        {
            boxes.Add(new Box
            {
                Name = tb_boxname.Text,
                RectX1 = nUD_rectx1.Value,
                RectY1 = nUD_recty1.Value,
                RectX2 = nUD_rectx2.Value,
                RectY2 = nUD_recty2.Value,
                Font = cb_font.Text,
                FontSize = nUD_fontsize.Value,
                Color = colorshow.BackColor,
                Pic = cb_picsrcfrom.SelectedItem.ToString(),
                Flag = ((EnumHelper.ValueWrapper<TextAlign>) cb_flag.SelectedItem).Value
            });
            RefreshView();
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
            var dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            dialog.SelectedPath = Settings.Default.savefolder;
            //dialog.RootFolder = Environment.SpecialFolder.Programs;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var foldPath = dialog.SelectedPath + "\\";
                Settings.Default.savefolder = foldPath;
                Settings.Default.Save();
                tb_outdir.Text = foldPath;
            }
        }

        //选择输入参数函数
        private void btn_choosefile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false; //该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "有逗号分隔的文本文档(*.txt)|*.txt|逗号分隔文件(*.csv)|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = dialog.FileName;
                Settings.Default.inputtxtdir = filePath;
                Settings.Default.Save();
                tb_textdir.Text = filePath;
            }
        }

        //开始绘制线程函数
        private void btn_startdraw_Click(object sender, EventArgs e)
        {
            var t1 = new Thread(DrawProcess);
            btn_startdraw.Enabled = false;
            t1.IsBackground = true;
            t1.Start();
        }

        //绘制独立线程，防止程序假死
        public void DrawProcess()
        {
            var currentLine = 0;
            var currentBox = 0;
            var mode = string.Empty;
            var picSrc = string.Empty;
            string[] contents = null;
            var e = Settings.Default.srcpicdir;
            if (!File.Exists(Settings.Default.inputtxtdir))
            {
                MessageBox.Show("没有文件输入!");
                btn_startdraw.Enabled = true;
                return;
            }

            try
            {
                foreach (var str in File.ReadAllLines(Settings.Default.inputtxtdir, Encoding.UTF8))
                {
                    currentLine++;
                    currentBox = 0;

                    var tempImg = new Bitmap(SourceImage);
                    contents = str.Split(',');

                    if (contents.Length < boxes.Count)
                    {
                        // TODO: 抛出自定义异常
                        MessageBox.Show($"框数和第{currentLine}行分隔字段数不同，跳过");
                        break;
                    }

                    for (var i = 0; i < boxes.Count; i++)
                    {
                        currentBox = i;
                        boxes[i].Draw(contents[i], tempImg, false, false);
                    }

                    tempImg.Save(Settings.Default.savefolder + contents[0] + ".png");
                    btn_startdraw.Enabled = true;
                }
            }

            catch (Exception ex)
            {
                var a = dgv_boxesdata.Rows.Count.ToString();
                var b = contents.Length.ToString();
                var c = Settings.Default.inputtxtdir;
                var d = picSrc;
                if (dgv_boxesdata.Rows.Count != contents.Length)
                {
                    a += "---<!框数和分隔字段数不同>";
                    b += "---<!框数和分隔字段数不同>";
                }

                if (!File.Exists(c))
                    c += "---<!文件不存在>";
                if (!File.Exists(d))
                    d += "---<!文件不存在>";

                var errormessage = "出现绘制错误,已退出绘制！\n!!!!!!!(错误内容以---<!>显示)!!!!!!!\n======**======\n尝试绘制行:" + currentLine +
                                   "\n尝试绘制文本框:" + currentBox + "\n文本框数:" + a + "\n行分隔字段数:" + b + "\n输出:" +
                                   Settings.Default.savefolder + "\n输入文件:" + c + "\n图像来源:\n模式:" + mode + "\n相对路径:" + e +
                                   "\n完整路径:" + d +
                                   "\n======**======\n常见解决方案:\n检查输入文件和图像来源是否存在\n检查输入文件的尝试绘制行中分隔字段数是否与当前文本框数相同\n======**======\n高级错误信息，汇报请上传截图：" +
                                   ex;
                MessageBox.Show(errormessage);
            }

            btn_startdraw.Enabled = true;
        }

        private void colorshow_Click(object sender, EventArgs e)
        {
            var colorDia = new ColorDialog();

            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                //获取所选择的颜色
                var colorChoosed = colorDia.Color;
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
            Last_X = (int) (SourceImage.Width * (e.X / wd));
            Last_Y = (int) (SourceImage.Height * (e.Y / ht));
            l_pos.Text = "truepixel(" + Last_X + "," + Last_Y + ")";

            if (IsMouseDown)
            {
                var tempImg = new Bitmap(SourceImage);
                var g = Graphics.FromImage(tempImg);
                //LDebugger.Text = ((int)Math.Abs((Math.Sin(Stopwatch.ElapsedMilliseconds * 0.001) * 100))).ToString();
                //Brush br = new SolidBrush(Color.FromArgb((int)(Math.Sin(Stopwatch.ElapsedMilliseconds * 0.001) * 25)+100, 255, 200, 0));
                Brush br = new SolidBrush(Color.FromArgb(100, 255, 200, 0));
                g.FillRectangle(br,
                    new Rectangle(Math.Min(Down_X, Last_X), Math.Min(Down_Y, Last_Y), Math.Abs(Last_X - Down_X),
                        Math.Abs(Last_Y - Down_Y)));
                pBmainview.Image = tempImg;
            }
        }

        private void dgv_boxesdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_boxesdata.RowCount == 0)
                return;
            if (dgv_boxesdata.CurrentCell.OwningColumn.Name == color.Name)
            {
                var colorDia = new ColorDialog();

                if (colorDia.ShowDialog() == DialogResult.OK)
                {
                    //获取所选择的颜色
                    var colorChoosed = colorDia.Color;
                    //改变 Box.Color
                    (dgv_boxesdata.CurrentRow.DataBoundItem as Box).Color = colorChoosed;
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
            if (IsShowBack)
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

        private void btn_savecfg_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
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
                var filename = sfd.FileName;
                using (var sw = new StreamWriter(filename))
                {
                    foreach (var box in boxes)
                        sw.WriteLine(box.Serialize());
                }

                MessageBox.Show("保存成功");
            }
        }

        private void btn_loadcfg_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择文件";
            dialog.Filter = "框集合BoxSet（*.bs,*.tbs）|*.bs;*.tbs";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dgv_boxesdata.Rows.Clear();
                dgv_boxesdata.Refresh();
                var currentLine = 0;
                var filePath = dialog.FileName;
                boxes.Clear();
                foreach (var box in File.ReadAllLines(filePath).Select(Box.Parse))
                {
                    currentLine++;
                    if (box is null)
                        MessageBox.Show("载入错误:行" + currentLine);
                    else
                        boxes.Add(box);
                }

                dgv_boxesdata.Refresh();
                RefreshView();
            }
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            IsResizing = true;
            var side = SourceImage.Width > SourceImage.Height ? SourceImage.Height : SourceImage.Width;
            var tempImg = new Bitmap(SourceImage);

            using (var g = Graphics.FromImage(tempImg))
            {
                Brush br = new SolidBrush(Color.FromArgb(100, 255, 200, 0));
                var outerRect = new Rectangle(0, 0, side, side);
                var innerRect = new Rectangle(5, 5, side - 5, side - 5);
                g.FillRectangle(br, outerRect);
                g.FillRectangle(br, innerRect);
                g.DrawString("我是个正方形,如果看起来不像,调整窗口大小直到我看上去像正方形，或者你也可以对照下面的预览比例和实际比例进行调整",
                    new Font("黑体", 50), Brushes.Red, innerRect, new StringFormat(0));
            }

            pBmainview.Image = tempImg;
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
            if (dgv_boxesdata.CurrentRow == null || dgv_boxesdata.CurrentRow.Index <= 0) return;
            var index = dgv_boxesdata.CurrentRow.Index;

            try
            {
                Helper.Swap(boxes, index - 1, index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            RefreshView();
        }

        private void pBmainview_Resize(object sender, EventArgs e)
        {
            if (IsResizing)
                l_size.Text = "预览比例(" + (pBmainview.Height * 1.0 / pBmainview.Width).ToString("N2") + ")可能与原图(" +
                              (SourceImage.Height * 1.0 / SourceImage.Width).ToString("N2") +
                              ")不一致\n但不影响输出情况(如何调整比例？拉伸窗口！)";
        }

        private void btn_opensavefolder_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.savefolder);
        }

        private void dgv_boxesdata_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // 自动把 Box.Color 应用到单元格
            var index = e.RowIndex;
            var targetStyle = dgv_boxesdata.Rows[index].Cells[color.Name].Style;
            targetStyle.BackColor = boxes[index].Color;
            targetStyle.SelectionBackColor = boxes[index].Color;
        }

        private void btn_movedown_Click(object sender, EventArgs e)
        {
            if (dgv_boxesdata.CurrentRow == null ||
                dgv_boxesdata.CurrentRow.Index == dgv_boxesdata.RowCount - 1) return;
            var index = dgv_boxesdata.CurrentRow.Index;

            try
            {
                Helper.Swap(boxes, index + 1, index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            RefreshView();
        }

        private void btn_choosepicfolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            dialog.SelectedPath = Settings.Default.srcpicdir;
            //dialog.RootFolder = Environment.SpecialFolder.Programs;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var foldPath = dialog.SelectedPath + "\\";
                Settings.Default.srcpicdir = foldPath;
                Settings.Default.Save();
                tb_srcpicfolder.Text = foldPath;
            }
        }

        private void cb_picsrcfrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_picsrcfrom.Text == "仅文字无图")
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
            try
            {
                var y = dgv_boxesdata.CurrentCellAddress.Y;
                boxes.Insert(y, Helper.DeepCopy(boxes[y]));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            RefreshView();
        }
    }
}