using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CardEditor
{
    public partial class Inspector : Form
    {
        Form1 f;
        CardBox box;

        public Inspector()
        {
            InitializeComponent();
        }

        private void Inspector_Load(object sender, EventArgs e)
        {
            foreach (FontFamily i in new System.Drawing.Text.InstalledFontCollection().Families)
            {
                cb_font.Items.Add(i.Name.ToString());
            }

            f = Form1.current;

            UpdateData();
        }

        public void UpdateData()
        {
            if (f.boxes.Count <= 0) return;
            if (f.selectedIndex == -1) return;
            box = f.boxes[f.selectedIndex];
            boxName.Text = box.name;
            tb_rx1.Value = box.rx1;
            tb_rx2.Value = box.rx2;
            tb_ry1.Value = box.ry1;
            tb_ry2.Value = box.ry2;
            cb_font.Text = box.font.FontFamily.Name;
            tb_fontSize.Value = decimal.Parse(box.font.Size.ToString());
            cb_flag.Text = CardBox.FlagToString(box.flag);
            cb_picsrcfrom.Text = CardBox.PictureSrcToString(box.pictureSrc);
            colorshow.BackColor = box.color;
        }

        private void BoxName_TextChanged(object sender, EventArgs e)
        {
            f.boxes[f.selectedIndex].name = boxName.Text;
            RefreshV();
        }

        private void Tb_rx1_ValueChanged(object sender, EventArgs e)
        {
            f.boxes[f.selectedIndex].rx1 = (int)tb_rx1.Value; RefreshV();

        }

        private void Tb_ry1_ValueChanged(object sender, EventArgs e)
        {
            f.boxes[f.selectedIndex].ry1 = (int)tb_ry1.Value; RefreshV();


        }
        private void Tb_ry2_ValueChanged(object sender, EventArgs e)
        {
            f.boxes[f.selectedIndex].ry2 = (int)tb_ry2.Value; RefreshV();


        }
        private void Tb_rx2_ValueChanged(object sender, EventArgs e)
        {
            f.boxes[f.selectedIndex].rx2 = (int)tb_rx2.Value; RefreshV();
        }



        private void RefreshV()
        {
            f.RefreshTable();
            f.RefreshView();
        }

        private void Inspector_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.isInspectorOn = false;
        }

        private void Cb_font_TextChanged(object sender, EventArgs e)
        {
            f.boxes[f.selectedIndex].font = new Font(cb_font.Text, (float)tb_fontSize.Value); RefreshV();
        }

        private void Tb_fontSize_ValueChanged(object sender, EventArgs e)
        {
            f.boxes[f.selectedIndex].font = new Font(cb_font.Text, (float)tb_fontSize.Value); RefreshV();
        }

        private void Cb_flag_TextChanged(object sender, EventArgs e)
        {
            f.boxes[f.selectedIndex].flag = CardBox.ParseFlag(cb_flag.Text); RefreshV();
        }

        private void Colorshow_Click(object sender, EventArgs e)
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

        private void Colorshow_BackColorChanged(object sender, EventArgs e)
        {
            f.boxes[f.selectedIndex].color = colorshow.BackColor; RefreshV();
        }

        private void Cb_picsrcfrom_TextChanged(object sender, EventArgs e)
        {
            f.boxes[f.selectedIndex].pictureSrc = CardBox.ParsePictureSrc(cb_picsrcfrom.Text); RefreshV();
        }
    }
}
