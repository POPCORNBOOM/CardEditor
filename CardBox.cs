using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CardEditor
{
    /*
        直接读取表格中的数据需要频繁判断字符串，比较累
        此处创建的CardBox类用于封装文本框/图片框对象，可以直接读取/写入
        
        TODO: 在Form1.cs中使用一个集合(Dictionary或者List)储存所有CardBox对象，而所有UI上的显示都从该集合中同步
    */

    [Serializable]
    public class CardBox
    {
        public string name;
        public int rx1, rx2;
        public int ry1, ry2;
        public Font font;
        public Color color;
        public Flag flag;
        public PictureSrc pictureSrc;

        public CardBox Clone()
        {
            CardBox c = new CardBox();
            c.name = name;
            c.rx1 = rx1;
            c.ry1 = ry1;
            c.rx2 = rx2;
            c.ry2 = ry2;
            c.font = font;
            c.color = color;
            c.flag = flag;
            c.pictureSrc = pictureSrc;
            return c;
        }

        public static Flag ParseFlag(string str)
        {
            Flag f;
            switch (str)
            {
                case "居左0":
                    f = Flag.Left_Horizontal;
                    break;

                case "居右1":
                    f = Flag.Right_Horizontal;
                    break;

                case "竖左2":
                    f = Flag.Left_Vertical;
                    break;

                case "竖右3":
                    f = Flag.Right_Vertical;
                    break;

                default:
                    f = Flag.All_Line;
                    break;
            }

            return f;
        }

        public static string FlagToString(Flag f)
        {
            switch (f)
            {
                case Flag.Left_Horizontal:
                    return "居左0";
                case Flag.Right_Horizontal:
                    return "居右1";
                case Flag.Left_Vertical:
                    return "竖左2";
                case Flag.Right_Vertical:
                    return "竖右3";
                case Flag.All_Line:
                    return "整行";
                default: return "整行";
            }
        }

        public static PictureSrc ParsePictureSrc(string str)
        {
            PictureSrc src;

            switch (str)
            {
                case "仅文字无图":
                    src = PictureSrc.None;
                    break;

                case "从绝对路径":
                    src = PictureSrc.AbsolutePath;
                    break;

                case "从相对路径":
                    src = PictureSrc.RelativePath;
                    break;

                default:
                    src = PictureSrc.None;
                    break;
            }

            return src;
        }

        public static string PictureSrcToString(PictureSrc src)
        {
            switch (src)
            {
                case PictureSrc.None: return "仅文字无图";
                case PictureSrc.AbsolutePath: return "从绝对路径";
                case PictureSrc.RelativePath: return "从相对路径";
                default: return "仅文字无图";
            }
        }
    }

    public enum Flag
    {
        Left_Horizontal = 0,        //居左
        Right_Horizontal = 1,       //居右
        Left_Vertical = 2,          //竖左
        Right_Vertical = 3,         //竖右
        All_Line = 4096             //整行
    }

    public enum PictureSrc
    {
        None,                   //仅文字无图
        AbsolutePath,           //从绝对路径
        RelativePath            //从相对路径
    }
}
