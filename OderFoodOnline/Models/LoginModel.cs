using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OderFoodOnline.Models
{
    public class LoginModel
    {
        [Key]
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username must not be null")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Password must not be null")]
        [Display(Name = "Password")]
        public string Password { set; get; }
    }
}