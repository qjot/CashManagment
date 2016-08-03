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

        public virtual DbSet<Account> account { get; set; }
        public virtual DbSet<Person> person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.surname)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.password)
                .IsFixedLength();
        }
    }
}
