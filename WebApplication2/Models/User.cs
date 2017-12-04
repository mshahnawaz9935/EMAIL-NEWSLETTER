using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class User
    {
        [Key]
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string source { get; set; }

    }
}