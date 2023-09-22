using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Model
{
    public class UserModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string RoleName { get; set; }
        public string Address { get; set; }
        public int ProfileImageId { get; set; }
        public string ProfileImage { get; set; }
        public string ReturnUrl { get; set; }
        public SelectList RolesList { get; set; }
        public int? WorkingLanguageId { get; set; }
    }
}
