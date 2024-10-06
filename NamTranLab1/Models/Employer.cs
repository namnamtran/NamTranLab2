using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NamTranLab1.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
      
        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "Website")]
        public string Website { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Incorporated Date")]
        public DateTime? IncorporatedDate { get; set; }
    }
}
