using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramming.Models
{
    public class SignUpModel
    {
        [Required(ErrorMessage = "Not Empty Username")]
        [StringLength(100, ErrorMessage = "Username Max Lenght 100")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Not Empty Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Not Empty Confirm Password")]
        [Compare("Password",ErrorMessage = "ConfirmPassword Not Match Password")]
        public string ConfrimPassword { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Phone(ErrorMessage ="Invalid TelphoneNumber")]
        [StringLength(15,ErrorMessage = "TelphoneNumber Max lenght 15")]
        public string TelphoneNumber { get; set; }
    }
}