using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.ViewModels
{
    public class ProductsViewModel
    {
        public ProductsViewModel()
        {
            ListImages = new List<AttachmentsViewModel>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string ImageUrl { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string TotalView { get; set; }
        public string FavIcon { get; set; }
        public string CreateByUserName { get; set; } 
        public string CreateDateMonth { get; set; }
     
        public bool IsPublish { get; set; }
     

        public string StartDate { get; set; }
        public string Price { get; set; }
        public string Duration { get; set; }
        public IList<AttachmentsViewModel> ListImages { get; set; }
    }
}
