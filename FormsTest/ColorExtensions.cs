using System;
namespace FormsTest
{
    public static class ColorExtensions
    {
        public static string ToHex(this Xamarin.Forms.Color color)
        {
            var red = (byte)(color.R * 255);
            var green = (byte)(color.G * 255);
            var blue = (byte)(color.B * 255);
            var alpha = (byte)(color.A * 255);
            var hex = $"#{alpha:X2}{red:X2}{green:X2}{blue:X2}";

            return hex;
        }
    }
}
