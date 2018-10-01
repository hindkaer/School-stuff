namespace CodeFirstDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "Url");
        }
    }
}
