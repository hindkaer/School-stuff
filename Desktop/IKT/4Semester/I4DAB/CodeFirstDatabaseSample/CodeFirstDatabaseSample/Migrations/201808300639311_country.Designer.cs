// <auto-generated />
namespace CodeFirstDatabaseSample.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class country : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(country));
        
        string IMigrationMetadata.Id
        {
            get { return "201808300639311_country"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
