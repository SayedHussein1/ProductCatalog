using App.Domain.Model;
using App.Infra.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LocalizedProperty> LocalizedProperty { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AdminPages> AdminPages { get; set; }
        public virtual DbSet<RolePages> RolePages { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<SwitchMapping> SwitchMapping { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<LocaleStringResource> LocaleStringResource { get; set; }
        public virtual DbSet<ProductsHistory> ProductsHistory { get; set; }

        public virtual int Commit()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminPagesConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetRoleClaimsConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetRolesConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetUserClaimsConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetUserLoginsConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetUserRolesConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetUsersConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetUserTokensConfiguration());
            modelBuilder.ApplyConfiguration(new RolePagesConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductsConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new AttachmentConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
