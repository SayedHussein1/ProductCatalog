
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
    public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> entity)
        {

            entity.HasData(new Attachment
            {
               AttachmentId = 1,
               FileName = "3_PIC_3.jpg",
               FileExtension = ".jpg",
               FileSize = 4331, 
               MimeTypeValue = "image/jpeg"

            },

            new Attachment
            {
                AttachmentId = 2,
                FileName = "4_PIC_4.jpg",
                FileExtension = ".jpg",
                FileSize = 5746,
                MimeTypeValue = "image/jpeg"


            },

            new Attachment
            {
                AttachmentId = 3,
                FileName = "1_PIC_1.jpg",
                FileExtension = ".jpg",
                FileSize = 5118,
                MimeTypeValue = "image/jpeg"


            }
            ,
            new Attachment
            {
                AttachmentId = 4,
                FileName = "3_PIC_3.jpg",
                FileExtension = ".jpg",
                FileSize = 4331,
                MimeTypeValue = "image/jpeg"
            }
            );
        }
    }
}
