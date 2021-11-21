using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Registration_ASP_NET_CORE_RAZOR.Model
{
    public class Staffs
    {
        
        public int ID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        [Required]//RegularExpression(@"^[a - zA - Z0 - 9_.+ -] +@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email format")
        public string Email { get; set; }
        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
        [Required]
        [EnumDataType(typeof(MaritalStatus))]
        public MaritalStatus MaritalStatus { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Role { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DORValidate]
        public DateTime DOR { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Other 
    }
    public enum MaritalStatus
    {
       Single, Married
    }
}
