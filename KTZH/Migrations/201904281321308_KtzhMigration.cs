namespace KTZH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KtzhMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        HolderName = c.String(),
                        From = c.String(),
                        To = c.String(),
                        Price = c.Int(nullable: false),
                        DepartureDate = c.DateTime(nullable: false),
                        ArrivalDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tickets");
        }
    }
}
