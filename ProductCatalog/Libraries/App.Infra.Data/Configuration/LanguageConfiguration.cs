
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
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> entity)
        {

            entity.HasData(new Language
            {
                Id = 1, 
                LanguageCulture = "English en-US",
                Rtl = false,
                IsPublish = true,
                IsDeleted = false,
                DisplayOrder = 1,   
                Name = "EN",
            },
            
            new Language
            {
                Id = 2,
                LanguageCulture = "Arabic ar-EG",
                Rtl = true,
                IsPublish = true,
                IsDeleted = false,
                DisplayOrder = 2,
                Name = "AR"

            });
        }
    }
}
