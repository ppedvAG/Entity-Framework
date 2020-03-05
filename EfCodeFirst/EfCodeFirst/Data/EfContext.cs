using EfCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst.Data
{
    public class EfContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Kunde> Kunden { get; set; }
        public DbSet<Mitarbeiter> Mitarbeiter { get; set; }
        public DbSet<Abteilung> Abteilung { get; set; }

        public EfContext() : base("Server=WINDOWS10-AR2;Database=EfCodeFirst;Trusted_Connection=true;")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EfContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<EfContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EfContext, Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Mitarbeiter>().ToTable("Mitarbeiter");
            modelBuilder.Entity<Kunde>().ToTable("Opfer");

            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();


            modelBuilder.Entity<Mitarbeiter>().Property(x => x.Job).HasMaxLength(36).HasColumnName("Beruf").IsRequired();

            modelBuilder.Entity<Mitarbeiter>().Property(x => x.AnzahlOhren).HasColumnOrder(5);
            modelBuilder.Entity<Mitarbeiter>().Property(x => x.Schuhgöße).HasColumnOrder(4);


        }
    }
}
