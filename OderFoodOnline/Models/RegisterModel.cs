using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OderFoodOnline.Models
{
    public class RegisterModel
    {
        [Key]
        public long ID { set; get; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username must not be null")]

        public string UserName { set; get; }

        [Display(Name = "Password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be at least 6 character")]
        [Required(ErrorMessage = "Password must not be null")]
        public string Password { set; get; }

        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Confirm password does not match")]
        public string ConfirmPassword { set; get; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name must not be null")]
        public string Name { set; get; }

        [Display(Name = "Address")]
        public string Address { set; get; }

        [Required(ErrorMessage = "Email must not be null")]
        [Display(Name = "Email")]
        public string Email { set; get; }

        [Display(Name = "Phone number")]
        public string Phone { set; get; }

        [Display(Name = "City")]
        public string ProvinceID { set; get; }


        [Display(Name = "District")]
        public string DistrictID { set; get; }
    }
}