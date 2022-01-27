using System;
using System.Collections.Generic;
using System.Drawing;

namespace CardEditor
{
    /// <summary>
    /// 框对象
    /// </summary>
    public class Box
    {
        public string Name { get; set; }
        public decimal RectX1 { get; set; }
        public decimal RectX2 { get; set; }
        public decimal RectY1 { get; set; }
        public decimal RectY2 { get; set; }
        public string Font { get; set; }
        public decimal FontSize { get; set; }
        public Color Color { get; set; }
        public TextAlign Flag { get; set; }
        public string Pic { get; set; }
        public bool TextOnly => "仅文字无图".Equals(Pic);

        /// <summary>
        /// 将框的保存格式转换为 Box 对象
        /// </summary>
        /// <returns> Box 对象</returns>
        public static Box Parse(string line)
        {
            var split = line.Split(',');

            if (split.Length == 10)
            {
                return new Box
                {
                    Name = split[0],
                    RectX1 = int.Parse(split[1]),
                    RectY1 = int.Parse(split[2]),
                    RectX2 = int.Parse(split[3]),
                    RectY2 = int.Parse(split[4]),
                    Font = split[5],
                    FontSize = decimal.Parse(split[6]),
                    Color = ColorTranslator.FromHtml("#" + split[7]),
                    Flag = (TextAlign) int.Parse(split[8]),
                    Pic = split[9]
                };
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将 Box 对象转换为框的保存格式
        /// </summary>
        /// <returns>框的保存格式</returns>
        public string Serialize() =>
            $"{Name},{RectX1},{RectY1},{RectX2},{RectY2},{Font},{FontSize},{Color.ToArgb():X8},{(int) Flag},{Pic}";

        /// <summary>
        /// 在指定的 Image 上绘制对应的内容
        /// </summary>
        /// <param name="content">要绘制的内容：文本框的文字，图像的路径</param>
        /// <param name="target">要在其上绘制的 Image</param>
        /// <param name="drawBack">是否显示框区域</param>
        public void Draw(string content, Image target, bool drawBack)
        {
            var font = new Font(Font ?? "黑体", (float) FontSize);
            var sf = new StringFormat((StringFormatFlags) Flag);
            var fontBrush = new SolidBrush(Color);
            var backBrush = new SolidBrush(Color.FromArgb(100, 255 - Color.R, 255 - Color.G, 255 - Color.B));
            var g = Graphics.FromImage(target);
            var rect = RectangleF.FromLTRB((float) RectX1, (float) RectY1, (float) RectX2, (float) RectY2);

            if (drawBack)
            {
                g.FillRectangle(backBrush, rect);
            }

            if (!TextOnly)
            {
                g.DrawImage(Properties.Resources.defaultimg1, rect);
            }

            g.DrawString(content, font, fontBrush, rect, sf);
            g.Dispose();
        }
    }
}