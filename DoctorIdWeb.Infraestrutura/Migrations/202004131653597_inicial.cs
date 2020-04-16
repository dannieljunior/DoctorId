namespace DoctorIdWeb.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinicas",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(maxLength: 200, unicode: false),
                        Cnpj = c.String(maxLength: 20, unicode: false),
                        Telefone = c.String(maxLength: 20, unicode: false),
                        Endereco = c.String(maxLength: 500, unicode: false),
                        DtaCadastro = c.DateTime(nullable: false),
                        DtaAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Cnpj, unique: true, name: "IX_CLINICA_UNQ");
            
            CreateTable(
                "dbo.Convenios",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(maxLength: 200, unicode: false),
                        DtaCadastro = c.DateTime(nullable: false),
                        DtaAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Clinicas", "IX_CLINICA_UNQ");
            DropTable("dbo.Convenios");
            DropTable("dbo.Clinicas");
        }
    }
}
