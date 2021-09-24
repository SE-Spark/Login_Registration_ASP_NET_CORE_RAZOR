using System;
using System.ComponentModel.DataAnnotations;

namespace Login_Registration_ASP_NET_CORE_RAZOR.ViewModel
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="Password and confirm password did not match")]
        public string ConfirmPassword { get; set; }
    }
}
