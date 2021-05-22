using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class RegisterViewModel
    {
        [DisplayName("Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

        [DisplayName("Date Of Birth")]
        [Required(ErrorMessage = "Date Of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
