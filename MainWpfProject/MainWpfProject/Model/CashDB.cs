namespace MainWpfProject.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CashDB : DbContext
    {
        public CashDB()
            : base("name=CashDB")
        {
        }

        public virtual DbSet<account> account { get; set; }
        public virtual DbSet<person> person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<person>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<person>()
                .Property(e => e.surname)
                .IsFixedLength();

            modelBuilder.Entity<person>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<person>()
                .Property(e => e.password)
                .IsFixedLength();
        }
    }
}
