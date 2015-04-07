using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace fastMvcRush.Models
{
    public class GuestRequest
    {
        [Required(ErrorMessage="InputName")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? Come { get; set; }
    }
}