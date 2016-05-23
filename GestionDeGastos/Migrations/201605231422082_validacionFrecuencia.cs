namespace GestionDeGastos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validacionFrecuencia : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Frecuencias", "Tipo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Frecuencias", "Tipo", c => c.String());
        }
    }
}
