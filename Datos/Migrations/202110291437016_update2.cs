namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Especialidad",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Medico", "Especialidad_Id", c => c.Int());
            CreateIndex("dbo.Medico", "Especialidad_Id");
            AddForeignKey("dbo.Medico", "Especialidad_Id", "dbo.Especialidad", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medico", "Especialidad_Id", "dbo.Especialidad");
            DropIndex("dbo.Medico", new[] { "Especialidad_Id" });
            DropColumn("dbo.Medico", "Especialidad_Id");
            DropTable("dbo.Especialidad");
        }
    }
}
