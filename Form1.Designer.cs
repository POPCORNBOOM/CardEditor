
namespace CardEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_boxesdata = new System.Windows.Forms.DataGridView();
            this.boxname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rectx1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recty1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rectx2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recty2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.font = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fontsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pic = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_loadbase = new System.Windows.Forms.Button();
            this.tb_boxname = new System.Windows.Forms.TextBox();
            this.l_boxname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_font = new System.Windows.Forms.ComboBox();
            this.btn_startdraw = new System.Windows.Forms.Button();
            this.btn_addbox = new System.Windows.Forms.Button();
            this.tb_outdir = new System.Windows.Forms.TextBox();
            this.btn_choosefolder = new System.Windows.Forms.Button();
            this.tb_textdir = new System.Windows.Forms.TextBox();
            this.btn_choosefile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.l_xyplus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.l_pos = new System.Windows.Forms.Label();
            this.l_size = new System.Windows.Forms.Label();
            this.pBmainview = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_shouldlike = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_picsrcfrom = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_loadcfg = new System.Windows.Forms.Button();
            this.btn_savecfg = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nUD_recty1 = new System.Windows.Forms.NumericUpDown();
            this.nUD_recty2 = new System.Windows.Forms.NumericUpDown();
            this.nUD_rectx2 = new System.Windows.Forms.NumericUpDown();
            this.nUD_rectx1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.gb_text = new System.Windows.Forms.GroupBox();
            this.nUD_fontsize = new System.Windows.Forms.NumericUpDown();
            this.colorshow = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_flag = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_report = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_srcpicfolder = new System.Windows.Forms.TextBox();
            this.btn_choosepicfolder = new System.Windows.Forms.Button();
            this.btn_opensavefolder = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_boxesdata)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBmainview)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_recty1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_recty2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_rectx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_rectx1)).BeginInit();
            this.gb_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_fontsize)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_boxesdata
            // 
            this.dgv_boxesdata.AllowUserToAddRows = false;
            this.dgv_boxesdata.AllowUserToDeleteRows = false;
            this.dgv_boxesdata.AllowUserToResizeColumns = false;
            this.dgv_boxesdata.AllowUserToResizeRows = false;
            this.dgv_boxesdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_boxesdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_boxesdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_boxesdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boxname,
            this.rectx1,
            this.recty1,
            this.rectx2,
            this.recty2,
            this.font,
            this.fontsize,
            this.color,
            this.flag,
            this.pic});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_boxesdata.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_boxesdata.Location = new System.Drawing.Point(6, 204);
            this.dgv_boxesdata.MultiSelect = false;
            this.dgv_boxesdata.Name = "dgv_boxesdata";
            this.dgv_boxesdata.ReadOnly = true;
            this.dgv_boxesdata.RowHeadersVisible = false;
            this.dgv_boxesdata.RowHeadersWidth = 62;
            this.dgv_boxesdata.RowTemplate.Height = 23;
            this.dgv_boxesdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_boxesdata.Size = new System.Drawing.Size(763, 270);
            this.dgv_boxesdata.TabIndex = 1;
            this.dgv_boxesdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_boxesdata_CellClick);
            this.dgv_boxesdata.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_boxesdata_CellEndEdit);
            this.dgv_boxesdata.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_boxesdata_CellValueChanged);
            // 
            // boxname
            // 
            this.boxname.Frozen = true;
            this.boxname.HeaderText = "名称";
            this.boxname.MinimumWidth = 8;
            this.boxname.Name = "boxname";
            this.boxname.ReadOnly = true;
            this.boxname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.boxname.Width = 70;
            // 
            // rectx1
            // 
            this.rectx1.HeaderText = "x1";
            this.rectx1.MinimumWidth = 8;
            this.rectx1.Name = "rectx1";
            this.rectx1.ReadOnly = true;
            this.rectx1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rectx1.Width = 50;
            // 
            // recty1
            // 
            this.recty1.HeaderText = "y1";
            this.recty1.MinimumWidth = 8;
            this.recty1.Name = "recty1";
            this.recty1.ReadOnly = true;
            this.recty1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.recty1.Width = 50;
            // 
            // rectx2
            // 
            this.rectx2.HeaderText = "x2";
            this.rectx2.MinimumWidth = 8;
            this.rectx2.Name = "rectx2";
            this.rectx2.ReadOnly = true;
            this.rectx2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rectx2.Width = 50;
            // 
            // recty2
            // 
            this.recty2.HeaderText = "y2";
            this.recty2.MinimumWidth = 8;
            this.recty2.Name = "recty2";
            this.recty2.ReadOnly = true;
            this.recty2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.recty2.Width = 50;
            // 
            // font
            // 
            this.font.HeaderText = "字体";
            this.font.MinimumWidth = 8;
            this.font.Name = "font";
            this.font.ReadOnly = true;
            this.font.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.font.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.font.Width = 150;
            // 
            // fontsize
            // 
            this.fontsize.HeaderText = "字体大小";
            this.fontsize.MinimumWidth = 8;
            this.fontsize.Name = "fontsize";
            this.fontsize.ReadOnly = true;
            this.fontsize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fontsize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fontsize.Width = 80;
            // 
            // color
            // 
            this.color.HeaderText = "颜色";
            this.color.MinimumWidth = 8;
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.color.Width = 50;
            // 
            // flag
            // 
            this.flag.HeaderText = "对齐";
            this.flag.MinimumWidth = 8;
            this.flag.Name = "flag";
            this.flag.ReadOnly = true;
            this.flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.flag.Width = 60;
            // 
            // pic
            // 
            this.pic.HeaderText = "图片引用方式";
            this.pic.Items.AddRange(new object[] {
            "仅文字无图",
            "从绝对路径",
            "从相对路径"});
            this.pic.MinimumWidth = 6;
            this.pic.Name = "pic";
            this.pic.ReadOnly = true;
            this.pic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pic.Width = 110;
            // 
            // btn_loadbase
            // 
            this.btn_loadbase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_loadbase.Location = new System.Drawing.Point(0, 0);
            this.btn_loadbase.Name = "btn_loadbase";
            this.btn_loadbase.Size = new System.Drawing.Size(307, 32);
            this.btn_loadbase.TabIndex = 2;
            this.btn_loadbase.Text = "载入底图";
            this.btn_loadbase.UseVisualStyleBackColor = true;
            this.btn_loadbase.Click += new System.EventHandler(this.btn_loadbase_Click);
            // 
            // tb_boxname
            // 
            this.tb_boxname.Location = new System.Drawing.Point(15, 40);
            this.tb_boxname.Name = "tb_boxname";
            this.tb_boxname.Size = new System.Drawing.Size(80, 21);
            this.tb_boxname.TabIndex = 3;
            // 
            // l_boxname
            // 
            this.l_boxname.AutoSize = true;
            this.l_boxname.Location = new System.Drawing.Point(13, 20);
            this.l_boxname.Name = "l_boxname";
            this.l_boxname.Size = new System.Drawing.Size(65, 12);
            this.l_boxname.TabIndex = 4;
            this.l_boxname.Text = "文本框名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "点1(x1,y1)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "点2(x2,y2)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "字体";
            // 
            // cb_font
            // 
            this.cb_font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_font.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_font.FormattingEnabled = true;
            this.cb_font.Items.AddRange(new object[] {
            "黑体",
            "微软雅黑"});
            this.cb_font.Location = new System.Drawing.Point(43, 20);
            this.cb_font.Name = "cb_font";
            this.cb_font.Size = new System.Drawing.Size(143, 20);
            this.cb_font.TabIndex = 6;
            // 
            // btn_startdraw
            // 
            this.btn_startdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_startdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startdraw.Location = new System.Drawing.Point(1017, 524);
            this.btn_startdraw.Name = "btn_startdraw";
            this.btn_startdraw.Size = new System.Drawing.Size(77, 77);
            this.btn_startdraw.TabIndex = 7;
            this.btn_startdraw.Text = "绘制！";
            this.btn_startdraw.UseVisualStyleBackColor = true;
            this.btn_startdraw.Click += new System.EventHandler(this.btn_startdraw_Click);
            // 
            // btn_addbox
            // 
            this.btn_addbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addbox.Location = new System.Drawing.Point(15, 102);
            this.btn_addbox.Name = "btn_addbox";
            this.btn_addbox.Size = new System.Drawing.Size(80, 23);
            this.btn_addbox.TabIndex = 7;
            this.btn_addbox.Text = "新建文本框";
            this.btn_addbox.UseVisualStyleBackColor = true;
            this.btn_addbox.Click += new System.EventHandler(this.btn_addbox_Click);
            // 
            // tb_outdir
            // 
            this.tb_outdir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_outdir.Location = new System.Drawing.Point(12, 524);
            this.tb_outdir.Name = "tb_outdir";
            this.tb_outdir.ReadOnly = true;
            this.tb_outdir.Size = new System.Drawing.Size(836, 21);
            this.tb_outdir.TabIndex = 3;
            // 
            // btn_choosefolder
            // 
            this.btn_choosefolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choosefolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choosefolder.Location = new System.Drawing.Point(854, 524);
            this.btn_choosefolder.Name = "btn_choosefolder";
            this.btn_choosefolder.Size = new System.Drawing.Size(100, 23);
            this.btn_choosefolder.TabIndex = 7;
            this.btn_choosefolder.Text = "选择输出文件夹";
            this.btn_choosefolder.UseVisualStyleBackColor = true;
            this.btn_choosefolder.Click += new System.EventHandler(this.btn_choosefolder_Click);
            // 
            // tb_textdir
            // 
            this.tb_textdir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_textdir.Location = new System.Drawing.Point(12, 552);
            this.tb_textdir.Name = "tb_textdir";
            this.tb_textdir.ReadOnly = true;
            this.tb_textdir.Size = new System.Drawing.Size(836, 21);
            this.tb_textdir.TabIndex = 3;
            // 
            // btn_choosefile
            // 
            this.btn_choosefile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choosefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choosefile.Location = new System.Drawing.Point(854, 550);
            this.btn_choosefile.Name = "btn_choosefile";
            this.btn_choosefile.Size = new System.Drawing.Size(157, 23);
            this.btn_choosefile.TabIndex = 7;
            this.btn_choosefile.Text = "选择参数文件";
            this.btn_choosefile.UseVisualStyleBackColor = true;
            this.btn_choosefile.Click += new System.EventHandler(this.btn_choosefile_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.l_xyplus);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.l_pos);
            this.panel1.Controls.Add(this.l_size);
            this.panel1.Controls.Add(this.btn_loadbase);
            this.panel1.Controls.Add(this.pBmainview);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 503);
            this.panel1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(222, 486);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "显示框区域";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // l_xyplus
            // 
            this.l_xyplus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l_xyplus.Location = new System.Drawing.Point(-1, 434);
            this.l_xyplus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_xyplus.Name = "l_xyplus";
            this.l_xyplus.Size = new System.Drawing.Size(305, 12);
            this.l_xyplus.TabIndex = 12;
            this.l_xyplus.Text = "720,1000";
            this.l_xyplus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l_xyplus.UseMnemonic = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 32);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "0,0";
            // 
            // l_pos
            // 
            this.l_pos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_pos.AutoSize = true;
            this.l_pos.Font = new System.Drawing.Font("宋体", 9F);
            this.l_pos.Location = new System.Drawing.Point(4, 487);
            this.l_pos.Name = "l_pos";
            this.l_pos.Size = new System.Drawing.Size(89, 12);
            this.l_pos.TabIndex = 3;
            this.l_pos.Text = "truepixel(0,0)";
            // 
            // l_size
            // 
            this.l_size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_size.AutoSize = true;
            this.l_size.Font = new System.Drawing.Font("宋体", 9F);
            this.l_size.Location = new System.Drawing.Point(4, 460);
            this.l_size.Name = "l_size";
            this.l_size.Size = new System.Drawing.Size(11, 12);
            this.l_size.TabIndex = 3;
            this.l_size.Text = "x";
            // 
            // pBmainview
            // 
            this.pBmainview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBmainview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBmainview.Image = global::CardEditor.Properties.Resources._1;
            this.pBmainview.Location = new System.Drawing.Point(0, 47);
            this.pBmainview.Name = "pBmainview";
            this.pBmainview.Size = new System.Drawing.Size(307, 384);
            this.pBmainview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBmainview.TabIndex = 0;
            this.pBmainview.TabStop = false;
            this.pBmainview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBmainview_DrawArea_get);
            this.pBmainview.MouseLeave += new System.EventHandler(this.pBmainview_MouseLeave);
            this.pBmainview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBmainview_MouseMove);
            this.pBmainview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBmainview_MouseUp);
            this.pBmainview.Resize += new System.EventHandler(this.pBmainview_Resize);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tb_shouldlike);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dgv_boxesdata);
            this.panel2.Location = new System.Drawing.Point(325, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 503);
            this.panel2.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 487);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(587, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "生成图片默认以第一个框内容作为文件名，因此不能使用英文输入法下的< > / \\ | : \" * ?作为第一个框内容";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 475);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(665, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "双击条目以删除，选中后再次点击以编辑；框的绘制顺序是先绘制上面的(垫底)后绘制下面的(覆盖)，后绘制会覆盖先绘制的";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "输入文件的一行应该长这样：";
            // 
            // tb_shouldlike
            // 
            this.tb_shouldlike.Location = new System.Drawing.Point(165, 177);
            this.tb_shouldlike.Name = "tb_shouldlike";
            this.tb_shouldlike.ReadOnly = true;
            this.tb_shouldlike.Size = new System.Drawing.Size(587, 21);
            this.tb_shouldlike.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.tb_boxname);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_addbox);
            this.groupBox1.Controls.Add(this.gb_text);
            this.groupBox1.Controls.Add(this.l_boxname);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 160);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "创建文本框/图片框";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_picsrcfrom);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(534, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(105, 134);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "图片";
            // 
            // cb_picsrcfrom
            // 
            this.cb_picsrcfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_picsrcfrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_picsrcfrom.FormattingEnabled = true;
            this.cb_picsrcfrom.Items.AddRange(new object[] {
            "仅文字无图",
            "从绝对路径",
            "从相对路径"});
            this.cb_picsrcfrom.Location = new System.Drawing.Point(8, 46);
            this.cb_picsrcfrom.Name = "cb_picsrcfrom";
            this.cb_picsrcfrom.Size = new System.Drawing.Size(88, 20);
            this.cb_picsrcfrom.TabIndex = 6;
            this.cb_picsrcfrom.SelectedIndexChanged += new System.EventHandler(this.cb_picsrcfrom_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 5;
            this.label16.Text = "图片引用方式";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "无需图片时选择\r\n\"仅文字无图\"";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_loadcfg);
            this.groupBox4.Controls.Add(this.btn_savecfg);
            this.groupBox4.Location = new System.Drawing.Point(650, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(102, 134);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "框集合";
            // 
            // btn_loadcfg
            // 
            this.btn_loadcfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadcfg.Location = new System.Drawing.Point(8, 16);
            this.btn_loadcfg.Name = "btn_loadcfg";
            this.btn_loadcfg.Size = new System.Drawing.Size(75, 23);
            this.btn_loadcfg.TabIndex = 12;
            this.btn_loadcfg.Text = "载入集合";
            this.btn_loadcfg.UseVisualStyleBackColor = true;
            this.btn_loadcfg.Click += new System.EventHandler(this.btn_loadcfg_Click);
            // 
            // btn_savecfg
            // 
            this.btn_savecfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savecfg.Location = new System.Drawing.Point(8, 45);
            this.btn_savecfg.Name = "btn_savecfg";
            this.btn_savecfg.Size = new System.Drawing.Size(75, 23);
            this.btn_savecfg.TabIndex = 12;
            this.btn_savecfg.Text = "保存集合";
            this.btn_savecfg.UseVisualStyleBackColor = true;
            this.btn_savecfg.Click += new System.EventHandler(this.btn_savecfg_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nUD_recty1);
            this.groupBox2.Controls.Add(this.nUD_recty2);
            this.groupBox2.Controls.Add(this.nUD_rectx2);
            this.groupBox2.Controls.Add(this.nUD_rectx1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(101, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 134);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "位置";
            // 
            // nUD_recty1
            // 
            this.nUD_recty1.Location = new System.Drawing.Point(142, 21);
            this.nUD_recty1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nUD_recty1.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nUD_recty1.Name = "nUD_recty1";
            this.nUD_recty1.Size = new System.Drawing.Size(54, 21);
            this.nUD_recty1.TabIndex = 13;
            // 
            // nUD_recty2
            // 
            this.nUD_recty2.Location = new System.Drawing.Point(142, 48);
            this.nUD_recty2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nUD_recty2.Name = "nUD_recty2";
            this.nUD_recty2.Size = new System.Drawing.Size(54, 21);
            this.nUD_recty2.TabIndex = 13;
            // 
            // nUD_rectx2
            // 
            this.nUD_rectx2.Location = new System.Drawing.Point(82, 48);
            this.nUD_rectx2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nUD_rectx2.Name = "nUD_rectx2";
            this.nUD_rectx2.Size = new System.Drawing.Size(54, 21);
            this.nUD_rectx2.TabIndex = 13;
            // 
            // nUD_rectx1
            // 
            this.nUD_rectx1.Location = new System.Drawing.Point(82, 21);
            this.nUD_rectx1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nUD_rectx1.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nUD_rectx1.Name = "nUD_rectx1";
            this.nUD_rectx1.Size = new System.Drawing.Size(54, 21);
            this.nUD_rectx1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "在牌面预览中拖动划出框区域可自动填入\r\n两点坐标";
            // 
            // gb_text
            // 
            this.gb_text.Controls.Add(this.nUD_fontsize);
            this.gb_text.Controls.Add(this.colorshow);
            this.gb_text.Controls.Add(this.label6);
            this.gb_text.Controls.Add(this.label5);
            this.gb_text.Controls.Add(this.label11);
            this.gb_text.Controls.Add(this.label4);
            this.gb_text.Controls.Add(this.cb_flag);
            this.gb_text.Controls.Add(this.cb_font);
            this.gb_text.Location = new System.Drawing.Point(331, 20);
            this.gb_text.Name = "gb_text";
            this.gb_text.Size = new System.Drawing.Size(192, 134);
            this.gb_text.TabIndex = 10;
            this.gb_text.TabStop = false;
            this.gb_text.Text = "文字";
            // 
            // nUD_fontsize
            // 
            this.nUD_fontsize.Location = new System.Drawing.Point(43, 45);
            this.nUD_fontsize.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nUD_fontsize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_fontsize.Name = "nUD_fontsize";
            this.nUD_fontsize.Size = new System.Drawing.Size(143, 21);
            this.nUD_fontsize.TabIndex = 7;
            this.nUD_fontsize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colorshow
            // 
            this.colorshow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorshow.Location = new System.Drawing.Point(43, 98);
            this.colorshow.Name = "colorshow";
            this.colorshow.Size = new System.Drawing.Size(143, 20);
            this.colorshow.TabIndex = 7;
            this.colorshow.Click += new System.EventHandler(this.colorshow_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "颜色";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "大小";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "排版";
            // 
            // cb_flag
            // 
            this.cb_flag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_flag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_flag.FormattingEnabled = true;
            this.cb_flag.Items.AddRange(new object[] {
            "居左0",
            "居右1",
            "竖左2",
            "竖右3",
            "整行4096"});
            this.cb_flag.Location = new System.Drawing.Point(43, 72);
            this.cb_flag.Name = "cb_flag";
            this.cb_flag.Size = new System.Drawing.Size(143, 20);
            this.cb_flag.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(1053, 623);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "v2.2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(9, 620);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(539, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "Copyright © 2021 PopcornBoom All rights reserved.(Click to drop in at my github m" +
    "ainpage)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_report
            // 
            this.btn_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_report.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_report.Location = new System.Drawing.Point(987, 615);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(59, 23);
            this.btn_report.TabIndex = 12;
            this.btn_report.Text = "汇报Bug";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label15.Location = new System.Drawing.Point(716, 620);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(269, 12);
            this.label15.TabIndex = 12;
            this.label15.Text = "出现恼人的错误或异常退出？帮助项目更好地开发";
            // 
            // tb_srcpicfolder
            // 
            this.tb_srcpicfolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_srcpicfolder.Location = new System.Drawing.Point(12, 580);
            this.tb_srcpicfolder.Name = "tb_srcpicfolder";
            this.tb_srcpicfolder.ReadOnly = true;
            this.tb_srcpicfolder.Size = new System.Drawing.Size(836, 21);
            this.tb_srcpicfolder.TabIndex = 3;
            // 
            // btn_choosepicfolder
            // 
            this.btn_choosepicfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choosepicfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choosepicfolder.Location = new System.Drawing.Point(854, 578);
            this.btn_choosepicfolder.Name = "btn_choosepicfolder";
            this.btn_choosepicfolder.Size = new System.Drawing.Size(157, 23);
            this.btn_choosepicfolder.TabIndex = 7;
            this.btn_choosepicfolder.Text = "选择图片引用相对路径";
            this.btn_choosepicfolder.UseVisualStyleBackColor = true;
            this.btn_choosepicfolder.Click += new System.EventHandler(this.btn_choosepicfolder_Click);
            // 
            // btn_opensavefolder
            // 
            this.btn_opensavefolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_opensavefolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opensavefolder.Location = new System.Drawing.Point(956, 524);
            this.btn_opensavefolder.Name = "btn_opensavefolder";
            this.btn_opensavefolder.Size = new System.Drawing.Size(55, 23);
            this.btn_opensavefolder.TabIndex = 7;
            this.btn_opensavefolder.Text = "打开";
            this.btn_opensavefolder.UseVisualStyleBackColor = true;
            this.btn_opensavefolder.Click += new System.EventHandler(this.btn_opensavefolder_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.Gold;
            this.label17.ForeColor = System.Drawing.Color.IndianRed;
            this.label17.Location = new System.Drawing.Point(-2, 604);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1108, 12);
            this.label17.TabIndex = 11;
            this.label17.Text = "此新版本框位置的确定方式由(原点加宽长确定框)改成了(两点确定框),虽打开旧框集合文件不会报错,但(x2,y2)的值还是原来的(宽,长)请手动改为(x1+原宽,x" +
    "1+原高)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 640);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_choosepicfolder);
            this.Controls.Add(this.btn_choosefile);
            this.Controls.Add(this.btn_opensavefolder);
            this.Controls.Add(this.btn_choosefolder);
            this.Controls.Add(this.tb_srcpicfolder);
            this.Controls.Add(this.btn_startdraw);
            this.Controls.Add(this.tb_textdir);
            this.Controls.Add(this.tb_outdir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1122, 679);
            this.Name = "Form1";
            this.Text = "CardEditor";
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_boxesdata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBmainview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_recty1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_recty2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_rectx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_rectx1)).EndInit();
            this.gb_text.ResumeLayout(false);
            this.gb_text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_fontsize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBmainview;
        private System.Windows.Forms.DataGridView dgv_boxesdata;
        private System.Windows.Forms.Button btn_loadbase;
        private System.Windows.Forms.TextBox tb_boxname;
        private System.Windows.Forms.Label l_boxname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_font;
        private System.Windows.Forms.Button btn_startdraw;
        private System.Windows.Forms.Button btn_addbox;
        private System.Windows.Forms.TextBox tb_outdir;
        private System.Windows.Forms.Button btn_choosefolder;
        private System.Windows.Forms.TextBox tb_textdir;
        private System.Windows.Forms.Button btn_choosefile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gb_text;
        private System.Windows.Forms.Panel colorshow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label l_size;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_shouldlike;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_flag;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label l_pos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_loadcfg;
        private System.Windows.Forms.Button btn_savecfg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_xyplus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_srcpicfolder;
        private System.Windows.Forms.Button btn_choosepicfolder;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cb_picsrcfrom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nUD_fontsize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUD_recty1;
        private System.Windows.Forms.NumericUpDown nUD_recty2;
        private System.Windows.Forms.NumericUpDown nUD_rectx2;
        private System.Windows.Forms.NumericUpDown nUD_rectx1;
        private System.Windows.Forms.Button btn_opensavefolder;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxname;
        private System.Windows.Forms.DataGridViewTextBoxColumn rectx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recty1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rectx2;
        private System.Windows.Forms.DataGridViewTextBoxColumn recty2;
        private System.Windows.Forms.DataGridViewTextBoxColumn font;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn flag;
        private System.Windows.Forms.DataGridViewComboBoxColumn pic;
    }
}

