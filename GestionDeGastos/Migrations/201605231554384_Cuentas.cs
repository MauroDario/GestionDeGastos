namespace GestionDeGastos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cuentas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cuentas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaCreacion = c.DateTime(nullable: false),
                        Tipo_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TipoCuentas", t => t.Tipo_ID, cascadeDelete: true)
                .Index(t => t.Tipo_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cuentas", "Tipo_ID", "dbo.TipoCuentas");
            DropIndex("dbo.Cuentas", new[] { "Tipo_ID" });
            DropTable("dbo.Cuentas");
        }
    }
}
