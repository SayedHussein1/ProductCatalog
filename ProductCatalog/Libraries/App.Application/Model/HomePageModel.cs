using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Model
{
    public class HomePageModel : BaseModel
    {
        public int CategoryId { get; set; }
        public SelectList CategoryList { get; set; }
    }
}
