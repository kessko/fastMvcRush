using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace fastMvcRush.Models
{
    public class GuestRequest
    {
        [Required(ErrorMessage = "Please input Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please input email")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Input valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please input phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? Come { get; set; }
    }
}