namespace GestionDeGastos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class color : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TipoCuentas", "Color", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TipoCuentas", "Color");
        }
    }
}
