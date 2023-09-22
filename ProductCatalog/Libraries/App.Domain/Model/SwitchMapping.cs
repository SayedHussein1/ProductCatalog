using System;
using System.Collections.Generic;

namespace App.Domain.Model
{
    public partial class SwitchMapping
    {
        public int Id { get; set; }
        public int? ProductId { get; set; } 
        public int? SubCategoryId { get; set; }
        public int? CategoryId { get; set; }
        public virtual Products Product { get; set; }
        public virtual Category Category { get; set; }
    }
}
