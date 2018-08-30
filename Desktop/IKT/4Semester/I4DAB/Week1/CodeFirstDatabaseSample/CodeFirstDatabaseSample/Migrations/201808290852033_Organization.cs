namespace CodeFirstDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Organization : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "Organizations");
            DropPrimaryKey("dbo.Organizations");
            AddColumn("dbo.Organizations", "OrganizationId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Organizations", "OrganizationName", c => c.String());
            AddColumn("dbo.Organizations", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Organizations", "Username", c => c.String());
            AddPrimaryKey("dbo.Organizations", "OrganizationId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Organizations");
            AlterColumn("dbo.Organizations", "Username", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Organizations", "Discriminator");
            DropColumn("dbo.Organizations", "OrganizationName");
            DropColumn("dbo.Organizations", "OrganizationId");
            AddPrimaryKey("dbo.Organizations", "Username");
            RenameTable(name: "dbo.Organizations", newName: "Users");
        }
    }
}
