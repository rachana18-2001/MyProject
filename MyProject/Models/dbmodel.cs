using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MyProject.Models
{
    public partial class dbmodel : DbContext
    {
        public dbmodel()
            : base("name=dbmodel")
        {
        }

        public virtual DbSet<grivence> grivences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<grivence>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<grivence>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<grivence>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<grivence>()
                .Property(e => e.officename)
                .IsUnicode(false);

            modelBuilder.Entity<grivence>()
                .Property(e => e.officeaddress)
                .IsUnicode(false);

            modelBuilder.Entity<grivence>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<grivence>()
                .Property(e => e.description)
                .IsUnicode(false);
        }
    }
}
