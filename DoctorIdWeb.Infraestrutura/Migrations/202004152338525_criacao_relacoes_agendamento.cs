namespace DoctorIdWeb.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criacao_relacoes_agendamento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agendamentos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Data = c.DateTime(nullable: false),
                        ClinicaId = c.Guid(nullable: false),
                        ConvenioId = c.Guid(),
                        PacienteId = c.Guid(nullable: false),
                        Situacao = c.Int(nullable: false),
                        DtaCadastro = c.DateTime(nullable: false),
                        DtaAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Convenios", t => t.ConvenioId)
                .ForeignKey("dbo.Pacientes", t => t.PacienteId)
                .ForeignKey("dbo.Clinicas", t => t.ClinicaId)
                .Index(t => t.ClinicaId)
                .Index(t => t.ConvenioId)
                .Index(t => t.PacienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Agendamentos", "ClinicaId", "dbo.Clinicas");
            DropForeignKey("dbo.Agendamentos", "PacienteId", "dbo.Pacientes");
            DropForeignKey("dbo.Agendamentos", "ConvenioId", "dbo.Convenios");
            DropIndex("dbo.Agendamentos", new[] { "PacienteId" });
            DropIndex("dbo.Agendamentos", new[] { "ConvenioId" });
            DropIndex("dbo.Agendamentos", new[] { "ClinicaId" });
            DropTable("dbo.Agendamentos");
        }
    }
}
