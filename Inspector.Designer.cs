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
            this.btn_movedown = new System.Windows.Forms.Button();
            this.btn_moveup = new System.Windows.Forms.Button();
            this.btn_duplicate = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.l_selectedline = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CancelEdit = new System.Windows.Forms.Button();
            this.btn_SaveEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ry1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ry2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rx1)).BeginInit();
            this.gb_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fontSize)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.boxName);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gb_text);
            this.groupBox1.Controls.Add(this.l_boxname);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 430);
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
            this.groupBox5.Size = new System.Drawing.Size(225, 76);
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
            // 
            // colorshow
            // 
            this.colorshow.BackColor = System.Drawing.SystemColors.Control;
            this.colorshow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorshow.Location = new System.Drawing.Point(43, 98);
            this.colorshow.Name = "colorshow";
            this.colorshow.Size = new System.Drawing.Size(143, 20);
            this.colorshow.TabIndex = 7;
            this.colorshow.Click += new System.EventHandler(this.Colorshow_Click);
            this.colorshow.Paint += new System.Windows.Forms.PaintEventHandler(this.colorshow_Paint);
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
            "居中4",
            "整行4096"});
            this.cb_flag.Location = new System.Drawing.Point(43, 72);
            this.cb_flag.Name = "cb_flag";
            this.cb_flag.Size = new System.Drawing.Size(143, 20);
            this.cb_flag.TabIndex = 6;
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
            // l_boxname
            // 
            this.l_boxname.AutoSize = true;
            this.l_boxname.Location = new System.Drawing.Point(13, 20);
            this.l_boxname.Name = "l_boxname";
            this.l_boxname.Size = new System.Drawing.Size(65, 12);
            this.l_boxname.TabIndex = 4;
            this.l_boxname.Text = "文本框名称";
            // 
            // btn_movedown
            // 
            this.btn_movedown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_movedown.BackgroundImage = global::CardEditor.Properties.Resources.down32x;
            this.btn_movedown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_movedown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_movedown.Location = new System.Drawing.Point(217, 3);
            this.btn_movedown.Name = "btn_movedown";
            this.btn_movedown.Size = new System.Drawing.Size(32, 32);
            this.btn_movedown.TabIndex = 14;
            this.btn_movedown.UseVisualStyleBackColor = false;
            this.btn_movedown.Click += new System.EventHandler(this.btn_movedown_Click);
            // 
            // btn_moveup
            // 
            this.btn_moveup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_moveup.BackgroundImage = global::CardEditor.Properties.Resources.up32x;
            this.btn_moveup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_moveup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_moveup.Location = new System.Drawing.Point(179, 3);
            this.btn_moveup.Name = "btn_moveup";
            this.btn_moveup.Size = new System.Drawing.Size(32, 32);
            this.btn_moveup.TabIndex = 15;
            this.btn_moveup.UseVisualStyleBackColor = false;
            this.btn_moveup.Click += new System.EventHandler(this.btn_moveup_Click);
            // 
            // btn_duplicate
            // 
            this.btn_duplicate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_duplicate.BackgroundImage = global::CardEditor.Properties.Resources.duplicate32x;
            this.btn_duplicate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_duplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duplicate.Location = new System.Drawing.Point(104, 3);
            this.btn_duplicate.Name = "btn_duplicate";
            this.btn_duplicate.Size = new System.Drawing.Size(32, 32);
            this.btn_duplicate.TabIndex = 16;
            this.btn_duplicate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_duplicate.UseVisualStyleBackColor = false;
            this.btn_duplicate.Click += new System.EventHandler(this.btn_duplicate_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_del.BackgroundImage = global::CardEditor.Properties.Resources.del32x;
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Location = new System.Drawing.Point(142, 3);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(32, 32);
            this.btn_del.TabIndex = 17;
            this.btn_del.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // l_selectedline
            // 
            this.l_selectedline.AutoSize = true;
            this.l_selectedline.Location = new System.Drawing.Point(3, 8);
            this.l_selectedline.Name = "l_selectedline";
            this.l_selectedline.Size = new System.Drawing.Size(47, 12);
            this.l_selectedline.TabIndex = 18;
            this.l_selectedline.Text = "编辑行:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_CancelEdit);
            this.panel1.Controls.Add(this.btn_SaveEdit);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Controls.Add(this.l_selectedline);
            this.panel1.Controls.Add(this.btn_duplicate);
            this.panel1.Controls.Add(this.btn_movedown);
            this.panel1.Controls.Add(this.btn_moveup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 59);
            this.panel1.TabIndex = 19;
            // 
            // btn_CancelEdit
            // 
            this.btn_CancelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelEdit.BackColor = System.Drawing.Color.LightCoral;
            this.btn_CancelEdit.FlatAppearance.BorderSize = 0;
            this.btn_CancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelEdit.Location = new System.Drawing.Point(126, 36);
            this.btn_CancelEdit.Name = "btn_CancelEdit";
            this.btn_CancelEdit.Size = new System.Drawing.Size(126, 23);
            this.btn_CancelEdit.TabIndex = 19;
            this.btn_CancelEdit.Text = "取消";
            this.btn_CancelEdit.UseVisualStyleBackColor = false;
            this.btn_CancelEdit.Click += new System.EventHandler(this.btn_CancelEdit_Click);
            // 
            // btn_SaveEdit
            // 
            this.btn_SaveEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SaveEdit.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_SaveEdit.FlatAppearance.BorderSize = 0;
            this.btn_SaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveEdit.Location = new System.Drawing.Point(0, 36);
            this.btn_SaveEdit.Name = "btn_SaveEdit";
            this.btn_SaveEdit.Size = new System.Drawing.Size(126, 23);
            this.btn_SaveEdit.TabIndex = 19;
            this.btn_SaveEdit.Text = "保存";
            this.btn_SaveEdit.UseVisualStyleBackColor = false;
            this.btn_SaveEdit.Click += new System.EventHandler(this.btn_SaveEdit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 430);
            this.panel2.TabIndex = 20;
            // 
            // Inspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(252, 495);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_movedown;
        private System.Windows.Forms.Button btn_moveup;
        private System.Windows.Forms.Button btn_duplicate;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label l_selectedline;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_CancelEdit;
        private System.Windows.Forms.Button btn_SaveEdit;
        private System.Windows.Forms.Panel panel2;
    }
}