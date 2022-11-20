using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models.Framework
{
    public partial class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext()
            : base("name=OnlineShopDbContext1")
        {
        }

        public virtual DbSet<LogInFail> LogInFails { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogInFail>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleCode)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.RoleCode)
                .IsFixedLength();

            modelBuilder.Entity<Image>()
                .Property(e => e.FileType)
                .IsFixedLength();
        }
    }
}
