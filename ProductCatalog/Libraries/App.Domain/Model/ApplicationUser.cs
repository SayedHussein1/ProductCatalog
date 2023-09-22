using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string MobileToken { get; set; }
        public string FullName { get; set; }
        public int? WorkingLanguageId { get; set; }
        public string Address { get; set; }
        public int ProfileImageId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
