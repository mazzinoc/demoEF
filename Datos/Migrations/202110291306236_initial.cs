namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        MedicoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Matricula = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedicoId);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaNacimiento = c.DateTime(nullable: false, storeType: "date"),
                        NroHistoriaClinica = c.Int(nullable: false),
                        MedicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medico", t => t.MedicoId, cascadeDelete: true)
                .Index(t => t.MedicoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paciente", "MedicoId", "dbo.Medico");
            DropIndex("dbo.Paciente", new[] { "MedicoId" });
            DropTable("dbo.Paciente");
            DropTable("dbo.Medico");
        }
    }
}
