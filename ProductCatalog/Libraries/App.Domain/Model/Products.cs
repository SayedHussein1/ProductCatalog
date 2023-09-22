using App.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Model
{
    public partial class Products : BaseEntity, ILocalizedEntity
    {
        public Products()
        {
            SwitchMapping = new HashSet<SwitchMapping>();
            ProductImage = new HashSet<ProductImage>();
        }
        public int? ImageId { get; set; }
        public string Title { get; set; } 
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string CreateByUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublish { get; set; }
        public bool IsSolid { get; set; }
        public string CountryCode { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public double Duration { get; set; }
        public virtual Category Category { get; set; }
        public virtual AspNetUsers CreateByUser { get; set; }
        public virtual ICollection<SwitchMapping> SwitchMapping { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
    }
}
