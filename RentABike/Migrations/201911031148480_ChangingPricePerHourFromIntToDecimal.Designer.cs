// <auto-generated />
namespace RentABike.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class ChangingPricePerHourFromIntToDecimal : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(ChangingPricePerHourFromIntToDecimal));
        
        string IMigrationMetadata.Id
        {
            get { return "201911031148480_ChangingPricePerHourFromIntToDecimal"; }
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