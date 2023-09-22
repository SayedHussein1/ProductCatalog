using App.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Model
{
    public partial class ProductsHistory : BaseEntity
    {
        public int? ProductId { get; set; }
        public string MobileAppId { get; set; }
        public DateTime? CreateDate { get; set; }
        public virtual Products Product { get; set; }
    }
}
