namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medico", "EspecialidadId", c => c.Int(nullable: false));
            CreateIndex("dbo.Medico", "EspecialidadId");
            AddForeignKey("dbo.Medico", "EspecialidadId", "dbo.Especialidad", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medico", "EspecialidadId", "dbo.Especialidad");
            DropIndex("dbo.Medico", new[] { "EspecialidadId" });
            DropColumn("dbo.Medico", "EspecialidadId");
        }
    }
}
