
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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
          
            builder.Property(e => e.Name).HasMaxLength(200);
            builder.Property(e => e.CreateBy).HasMaxLength(450);
            builder.Property(e => e.UpdateBy).HasMaxLength(450);
            builder.Property(e => e.CreateDate).HasColumnType("datetime");
            builder.Property(e => e.UpdateDate).HasColumnType("datetime");

            builder.HasData(new Category
            {
                Id = 1, 
                Name = "Cat_1",
                CreateDate = DateTime.Now,  
                IsPublish = true,   
                IsDeleted = false,
                UpdateDate = DateTime.Now,  
            }
             ,
             new Category
             {
                 Id = 2,
                 Name = "Cat_2",
                 CreateDate = DateTime.Now,
                 IsPublish = true,
                 IsDeleted = false,
                 UpdateDate = DateTime.Now,

             },
             new Category
             {
                 Id = 3,
                 Name = "Cat_3",
                 CreateDate = DateTime.Now,
                 IsPublish = true,
                 IsDeleted = false,
                 UpdateDate = DateTime.Now,
             }
             ,
             new Category
             {
                 Id = 4,
                 Name = "Cat_4",
                 CreateDate = DateTime.Now,
                 IsPublish = true,
                 IsDeleted = false,
                 UpdateDate = DateTime.Now,
             }
             ,
             new Category
             {
                 Id = 5,
                 Name = "Cat_5",
                 CreateDate = DateTime.Now,
                 IsPublish = true,
                 IsDeleted = false,
                 UpdateDate = DateTime.Now,
             }
            );
        }
    }
}
