namespace GestionDeGastos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidacionCategoria : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categorias", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Categorias", "Descripcion", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categorias", "Descripcion", c => c.String());
            AlterColumn("dbo.Categorias", "Nombre", c => c.String());
        }
    }
}
