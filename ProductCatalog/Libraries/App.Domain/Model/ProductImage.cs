using System;
using System.Collections.Generic;

namespace App.Domain.Model
{
    public partial class ProductImage : BaseEntity
    { 
        public int? ProductId { get; set; } 
        public int? ImageId { get; set; }

        public virtual Products Product { get; set; } 
    }
}
