namespace GestionDeGastos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class icono : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TipoCuentas", "Icono", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TipoCuentas", "Icono");
        }
    }
}
