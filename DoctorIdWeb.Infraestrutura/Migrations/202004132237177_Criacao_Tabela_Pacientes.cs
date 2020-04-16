namespace DoctorIdWeb.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criacao_Tabela_Pacientes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(maxLength: 200, unicode: false),
                        Cpf = c.String(maxLength: 11, unicode: false),
                        Telefone = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 200, unicode: false),
                        DtaCadastro = c.DateTime(nullable: false),
                        DtaAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pacientes");
        }
    }
}
