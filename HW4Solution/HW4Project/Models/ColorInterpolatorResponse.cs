using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Drawing;


namespace HW4Project.Models 
{
    public class ColorInterpolatorResponse {

        [RegularExpression(@"^#{1}[A-Fa-f0-9]{3,6}$", ErrorMessage = "Use Hex format for the First Color please")]
        [Required]
        public string FirstColor { get; set; }

        [Required]
        [RegularExpression(@"^#{1}[A-Fa-f0-9]{3,6}$", ErrorMessage = "Use Hex format for the Second Color please")]
        public string SecondColor { get; set; }

        [Required]
        [Range(2,10000, ErrorMessage = "Please Enter a number between 2 and 1000")]
        public int NumberofColors { get; set; }

        public IEnumerable<string> ColorList { get; set; }

        public static void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }
                
    }
}