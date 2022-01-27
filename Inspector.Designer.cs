namespace CardEditor
{
    partial class Inspector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inspector));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_picsrcfrom = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_ry1 = new System.Windows.Forms.NumericUpDown();
            this.tb_ry2 = new System.Windows.Forms.NumericUpDown();
            this.tb_rx2 = new System.Windows.Forms.NumericUpDown();
            this.tb_rx1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_text = new System.Windows.Forms.GroupBox();
            this.tb_fontSize = new System.Windows.Forms.NumericUpDown();
            this.colorshow = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_flag = new System.Windows.Forms.ComboBox();
            this.cb_font = new System.Windows.Forms.ComboBox();
            this.l_boxname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ry1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ry2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rx1)).BeginInit();
            this.gb_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.boxName);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gb_text);
            this.groupBox1.Controls.Add(this.l_boxname);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 470);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑文本框/图片框";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_picsrcfrom);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(15, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(225, 134);
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
            this.cb_picsrcfrom.TextChanged += new System.EventHandler(this.Cb_picsrcfrom_TextChanged);
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
            this.label1.Location = new System.Drawing.Point(107, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "无需图片时选择\r\n\"仅文字无图\"";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(15, 40);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(80, 21);
            this.boxName.TabIndex = 3;
            this.boxName.TextChanged += new System.EventHandler(this.BoxName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_ry1);
            this.groupBox2.Controls.Add(this.tb_ry2);
            this.groupBox2.Controls.Add(this.tb_rx2);
            this.groupBox2.Controls.Add(this.tb_rx1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 81);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "位置";
            // 
            // tb_ry1
            // 
            this.tb_ry1.Location = new System.Drawing.Point(142, 21);
            this.tb_ry1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.tb_ry1.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.tb_ry1.Name = "tb_ry1";
            this.tb_ry1.Size = new System.Drawing.Size(54, 21);
            this.tb_ry1.TabIndex = 13;
            this.tb_ry1.ValueChanged += new System.EventHandler(this.Tb_ry1_ValueChanged);
            // 
            // tb_ry2
            // 
            this.tb_ry2.Location = new System.Drawing.Point(142, 48);
            this.tb_ry2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.tb_ry2.Name = "tb_ry2";
            this.tb_ry2.Size = new System.Drawing.Size(54, 21);
            this.tb_ry2.TabIndex = 13;
            this.tb_ry2.ValueChanged += new System.EventHandler(this.Tb_ry2_ValueChanged);
            // 
            // tb_rx2
            // 
            this.tb_rx2.Location = new System.Drawing.Point(82, 48);
            this.tb_rx2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.tb_rx2.Name = "tb_rx2";
            this.tb_rx2.Size = new System.Drawing.Size(54, 21);
            this.tb_rx2.TabIndex = 13;
            this.tb_rx2.ValueChanged += new System.EventHandler(this.Tb_rx2_ValueChanged);
            // 
            // tb_rx1
            // 
            this.tb_rx1.Location = new System.Drawing.Point(82, 21);
            this.tb_rx1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.tb_rx1.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.tb_rx1.Name = "tb_rx1";
            this.tb_rx1.Size = new System.Drawing.Size(54, 21);
            this.tb_rx1.TabIndex = 13;
            this.tb_rx1.ValueChanged += new System.EventHandler(this.Tb_rx1_ValueChanged);
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
            // gb_text
            // 
            this.gb_text.Controls.Add(this.tb_fontSize);
            this.gb_text.Controls.Add(this.colorshow);
            this.gb_text.Controls.Add(this.label6);
            this.gb_text.Controls.Add(this.label5);
            this.gb_text.Controls.Add(this.label11);
            this.gb_text.Controls.Add(this.label4);
            this.gb_text.Controls.Add(this.cb_flag);
            this.gb_text.Controls.Add(this.cb_font);
            this.gb_text.Location = new System.Drawing.Point(15, 178);
            this.gb_text.Name = "gb_text";
            this.gb_text.Size = new System.Drawing.Size(224, 134);
            this.gb_text.TabIndex = 10;
            this.gb_text.TabStop = false;
            this.gb_text.Text = "文字";
            // 
            // tb_fontSize
            // 
            this.tb_fontSize.Location = new System.Drawing.Point(43, 45);
            this.tb_fontSize.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.tb_fontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_fontSize.Name = "tb_fontSize";
            this.tb_fontSize.Size = new System.Drawing.Size(143, 21);
            this.tb_fontSize.TabIndex = 7;
            this.tb_fontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_fontSize.ValueChanged += new System.EventHandler(this.Tb_fontSize_ValueChanged);
            // 
            // colorshow
            // 
            this.colorshow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorshow.Location = new System.Drawing.Point(43, 98);
            this.colorshow.Name = "colorshow";
            this.colorshow.Size = new System.Drawing.Size(143, 20);
            this.colorshow.TabIndex = 7;
            this.colorshow.BackColorChanged += new System.EventHandler(this.Colorshow_BackColorChanged);
            this.colorshow.Click += new System.EventHandler(this.Colorshow_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "字体";
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
            this.cb_flag.TextChanged += new System.EventHandler(this.Cb_flag_TextChanged);
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
            this.cb_font.TextChanged += new System.EventHandler(this.Cb_font_TextChanged);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "行:";
            // 
            // Inspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 495);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(268, 534);
            this.MinimumSize = new System.Drawing.Size(268, 534);
            this.Name = "Inspector";
            this.Text = "属性";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inspector_FormClosed);
            this.Load += new System.EventHandler(this.Inspector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ry1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ry2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rx1)).EndInit();
            this.gb_text.ResumeLayout(false);
            this.gb_text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cb_picsrcfrom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown tb_ry1;
        private System.Windows.Forms.NumericUpDown tb_ry2;
        private System.Windows.Forms.NumericUpDown tb_rx2;
        private System.Windows.Forms.NumericUpDown tb_rx1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_text;
        private System.Windows.Forms.NumericUpDown tb_fontSize;
        private System.Windows.Forms.Panel colorshow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_flag;
        private System.Windows.Forms.ComboBox cb_font;
        private System.Windows.Forms.Label l_boxname;
        private System.Windows.Forms.Label label7;
    }
}