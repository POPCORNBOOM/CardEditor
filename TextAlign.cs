using System.ComponentModel;
using System.Drawing;

namespace CardEditor
{
    /// <summary>
    /// 对齐方式
    /// </summary>
    public enum TextAlign
    {
        [Description("居左")] Left = 0,
        [Description("居右")] Right = StringFormatFlags.DirectionRightToLeft,
        [Description("竖左")] VerticalLeft = StringFormatFlags.DirectionVertical,

        [Description("竖右")] VerticalRight = StringFormatFlags.DirectionRightToLeft
                                            | StringFormatFlags.DirectionVertical,
        [Description("整行")] Flat = StringFormatFlags.NoWrap
    }
}