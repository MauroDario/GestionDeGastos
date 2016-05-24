namespace GestionDeGastos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validacionCuneta2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cuentas", "Tipo_ID", "dbo.TipoCuentas");
            DropIndex("dbo.Cuentas", new[] { "Tipo_ID" });
            AlterColumn("dbo.Cuentas", "Tipo_ID", c => c.Int());
            CreateIndex("dbo.Cuentas", "Tipo_ID");
            AddForeignKey("dbo.Cuentas", "Tipo_ID", "dbo.TipoCuentas", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cuentas", "Tipo_ID", "dbo.TipoCuentas");
            DropIndex("dbo.Cuentas", new[] { "Tipo_ID" });
            AlterColumn("dbo.Cuentas", "Tipo_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Cuentas", "Tipo_ID");
            AddForeignKey("dbo.Cuentas", "Tipo_ID", "dbo.TipoCuentas", "ID", cascadeDelete: true);
        }
    }
}
