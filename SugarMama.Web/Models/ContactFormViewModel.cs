using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SugarMama.Web.Models
{
    public class ContactFormViewModel
    {
        [Required, EmailAddress]
        public string EmailAddress { get; set; }
        
        [Required, StringLength(255, MinimumLength = 4)]
        public string Subject { get; set; }
        
        [Required, StringLength(5000, MinimumLength = 2)]
        public string Body { get; set; }
    }
}