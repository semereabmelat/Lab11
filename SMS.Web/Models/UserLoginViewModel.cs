﻿using System.ComponentModel.DataAnnotations;

namespace SMS.Web.Models
{
    public class UserLoginViewModel
    {       
        [Required]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required]
        public string Password { get; set; }

    }
}