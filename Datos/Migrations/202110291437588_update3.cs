namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Medico", "Especialidad_Id", "dbo.Especialidad");
            DropIndex("dbo.Medico", new[] { "Especialidad_Id" });
            RenameColumn(table: "dbo.Medico", name: "Especialidad_Id", newName: "EspecialidadId");
            AlterColumn("dbo.Medico", "EspecialidadId", c => c.Int(nullable: false));
            CreateIndex("dbo.Medico", "EspecialidadId");
            AddForeignKey("dbo.Medico", "EspecialidadId", "dbo.Especialidad", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medico", "EspecialidadId", "dbo.Especialidad");
            DropIndex("dbo.Medico", new[] { "EspecialidadId" });
            AlterColumn("dbo.Medico", "EspecialidadId", c => c.Int());
            RenameColumn(table: "dbo.Medico", name: "EspecialidadId", newName: "Especialidad_Id");
            CreateIndex("dbo.Medico", "Especialidad_Id");
            AddForeignKey("dbo.Medico", "Especialidad_Id", "dbo.Especialidad", "Id");
        }
    }
}
