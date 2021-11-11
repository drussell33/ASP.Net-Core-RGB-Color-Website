using System.ComponentModel.DataAnnotations;

namespace HW4Project.Models 
{
    public class RGBResponce {

        [Required(ErrorMessage = "Please enter a R -or- (red) value")]
        [Range(0,255,ErrorMessage = "Please Enter a Number within Range for R")]
        public int Red { get; set; }

        [Required(ErrorMessage = "Please enter a G -or- (green) value")]
        [Range(0,255,ErrorMessage = "Please Enter a Number within Range for G")]
        public int Green { get; set; }

        [Required(ErrorMessage = "Please enter a B -or- (blue) value")]
        [Range(0,255,ErrorMessage = "Please Enter a Number within Range B")]
        public int Blue { get; set; }

        [RegularExpression(@"^#{1}[A-Fa-f0-9]{6}$", ErrorMessage = "Use Hex format for the Second Color please")]
        public string HexConverted { get; set; }


    }
}