using System;
using Xamarin.Forms;

namespace FormsTest
{
    public static class LineBreakModeExtensions
    {
        public static string ToText(this LineBreakMode mode)
        {
            switch(mode)
            {
                case LineBreakMode.CharacterWrap:
                    return nameof(LineBreakMode.CharacterWrap);
                case LineBreakMode.HeadTruncation:
                    return nameof(LineBreakMode.HeadTruncation);
				case LineBreakMode.MiddleTruncation:
                    return nameof(LineBreakMode.MiddleTruncation);
                case LineBreakMode.NoWrap:
                    return nameof(LineBreakMode.NoWrap);
                case LineBreakMode.TailTruncation:
                    return nameof(LineBreakMode.TailTruncation);
                case LineBreakMode.WordWrap:
                    return nameof(LineBreakMode.WordWrap);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
