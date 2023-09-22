
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
    public class AdminPagesConfiguration : IEntityTypeConfiguration<AdminPages>
    {
        public void Configure(EntityTypeBuilder<AdminPages> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Icon).HasMaxLength(200);

            builder.Property(e => e.PageTitle).HasMaxLength(200);

            builder.Property(e => e.PageUrl).HasMaxLength(200);

            builder.HasData(

                new AdminPages
                {
                    Id = 1,
                    PageTitle = "Products",
                    PageUrl = "Products",
                    Icon = "icon-git-pull-request",
                    DisplayOrder = 0,
                    ParentId = 0

                },
                new AdminPages
                {
                    Id = 2,
                    PageTitle = "Category",
                    PageUrl = "Category",
                    Icon = "icon-git-pull-request",
                    DisplayOrder = 1,
                    ParentId = 0

                },
                new AdminPages
                {
                    Id = 3,

                    PageTitle = "Language",
                    PageUrl = "Language",
                    Icon = "icon-git-pull-request",
                    DisplayOrder = 2,
                    ParentId = 0

                },
                new AdminPages
                {
                    Id = 4,

                    PageTitle = "Users",
                    PageUrl = "Users",
                    Icon = "icon-git-pull-request",
                    DisplayOrder = 3,
                    ParentId = 0

                },
                new AdminPages
                {
                    Id = 5,
                    PageTitle = "Roles",
                    PageUrl = "Groups",
                    Icon = "icon-git-pull-request",
                    DisplayOrder = 4,
                    ParentId = 0  
                }
            );



        }
    }
}