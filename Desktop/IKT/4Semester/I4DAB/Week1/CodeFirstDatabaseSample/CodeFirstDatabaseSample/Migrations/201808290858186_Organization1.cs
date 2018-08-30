namespace CodeFirstDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Organization1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        display_name = c.String(),
                        Organization_OrganizationId = c.Int(),
                    })
                .PrimaryKey(t => t.Username)
                .ForeignKey("dbo.Organizations", t => t.Organization_OrganizationId)
                .Index(t => t.Organization_OrganizationId);
            
            DropColumn("dbo.Organizations", "Username");
            DropColumn("dbo.Organizations", "display_name");
            DropColumn("dbo.Organizations", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Organizations", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Organizations", "display_name", c => c.String());
            AddColumn("dbo.Organizations", "Username", c => c.String());
            DropForeignKey("dbo.Users", "Organization_OrganizationId", "dbo.Organizations");
            DropIndex("dbo.Users", new[] { "Organization_OrganizationId" });
            DropTable("dbo.Users");
        }
    }
}
