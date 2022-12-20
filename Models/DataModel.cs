using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Zeeshan_Proj.Models
{
    public class DataModel
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [RegularExpression("[a-z,A-Z]+$", ErrorMessage = "Use Alphabets Only.")]
        [Required(ErrorMessage = "Please Ente Name.")]
        [Display(Name = "Name ")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        [Required(ErrorMessage = "Please Enter Email.")]
        [Display(Name = "Email ")]
        public string email { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [RegularExpression("[0-9]+$", ErrorMessage = "Use Numbers Only.")]
        [Required(ErrorMessage = "Please Enter Number.")]
        [Display(Name = "Contact ")]
        public string contact { get; set; }
        [Required]
        public int Password { get; set; }
    }
}
