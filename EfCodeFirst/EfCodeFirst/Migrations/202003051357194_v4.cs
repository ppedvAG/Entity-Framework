namespace EfCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mitarbeiter", "Schuhgöße", c => c.Int(nullable: false));
            AddColumn("dbo.Mitarbeiter", "AnzahlOhren", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mitarbeiter", "AnzahlOhren");
            DropColumn("dbo.Mitarbeiter", "Schuhgöße");
        }
    }
}
