using ppedv.Finex.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.Finex.Data.EF
{
    public class EfContext : DbContext
    {
        public DbSet<Apotheke> Apotheken { get; set; }
        public DbSet<Lager> Lager { get; set; }
        public DbSet<Medikament> Medikamente { get; set; }

        public EfContext(string conString) : base(conString)
        { }

        public EfContext() : this("Server=WINDOWS10-AR2;Database=Finex_dev;Trusted_Connection=true")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            //doof
            //modelBuilder.Entity<Medikament>().Property(x => x.Modified).HasColumnType("datetime2");
            //modelBuilder.Entity<Medikament>().Property(x => x.Created).HasColumnType("datetime2");
            // modelBuilder.Entity<Entity>().Property(x => x.Created).HasColumnType("datetime2");


            //konvention: Properties mit dem Namen 'Created' oder 'Modified' sollten datetime2 als Spaltentyp haben
            modelBuilder.Properties<DateTime>().Where(x => x.Name == nameof(Entity.Created) || x.Name == nameof(Entity.Modified))
                                               .Configure(x => x.HasColumnType("datetime2"));

        }

    }
}
