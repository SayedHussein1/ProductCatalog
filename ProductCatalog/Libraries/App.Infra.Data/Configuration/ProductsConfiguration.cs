
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using App.Domain.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Configuration
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
             
            builder.Property(e => e.CreateByUserId).HasMaxLength(450);
            builder.Property(e => e.Title).HasMaxLength(200);
            builder.Property(e => e.FullDescription).HasMaxLength(1000);
            builder.Property(e => e.ShortDescription).HasMaxLength(1000);

            builder.HasData(new Products
            {
                Id = 1, 
                Title = "Product_1",
                CategoryId = 1, 
                ShortDescription = "Product_1",
                FullDescription = "Product_1",
                CreateByUserId = "3497bcc8-dabe-4a3f-a560-37f8fde72ace",
                ImageId = 1,    
                IsDeleted = false,
                IsPublish = true,
                CreateDate = DateTime.Now,  
                StartDate = DateTime.Now.AddDays(1),
                Price = 200,
                Duration = 5,


            },

            new Products
            {
                Id = 2, 
                Title = "Product_2",
                CategoryId = 2,
                ShortDescription = "Product_2",
                FullDescription = "Product_2",
                CreateByUserId = "3497bcc8-dabe-4a3f-a560-37f8fde72ace",
                ImageId = 2,
                IsDeleted = false,
                IsPublish = true,
                CreateDate = DateTime.Now,
                StartDate = DateTime.Now.AddDays(3),
                Price = 100,
                Duration = 4,


            },
            new Products
            {
                Id = 3, 
                Title = "Product_3",
                CategoryId = 3,
                ShortDescription = "Product_3",
                FullDescription = "Product_3",
                CreateByUserId = "3497bcc8-dabe-4a3f-a560-37f8fde72ace",
                ImageId = 3,
                IsDeleted = false,
                IsPublish = true,
                CreateDate = DateTime.Now,
                StartDate = DateTime.Now.AddDays(1),
                Price = 250,
                Duration = 5,


            },
            new Products
            {
                Id = 4, 
                Title = "Product_4",
                CategoryId = 4,
                ShortDescription = "Product_4",
                FullDescription = "Product_4",
                CreateByUserId = "3497bcc8-dabe-4a3f-a560-37f8fde72ace",
                ImageId = 4,
                IsDeleted = false,
                IsPublish = true,
                CreateDate = DateTime.Now,
                StartDate = DateTime.Now.AddDays(6),
                Price = 300,
                Duration = 6,
            }




            );

        }
    }
}
