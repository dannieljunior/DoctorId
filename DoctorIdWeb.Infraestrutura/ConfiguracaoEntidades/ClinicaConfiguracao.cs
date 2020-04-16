using DoctorIdWeb.Infraestrutura.Core;
using DoctorIdWeb.Infraestrutura.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace DoctorIdWeb.Infraestrutura.ConfiguracaoEntidades
{
    public class ClinicaConfiguracao: EntidadeConfiguracao<Clinica>
    {
        public ClinicaConfiguracao()
        {
            ToTable("Clinicas");
            Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(200);

            Property(x => x.Cnpj)
                .HasColumnType("varchar").HasMaxLength(20)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, 
                                    new IndexAnnotation(new IndexAttribute("IX_CLINICA_UNQ", 1)
                                        {
                                            IsUnique = true
                                    }));

            Property(x => x.Telefone).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.Endereco).HasColumnType("varchar").HasMaxLength(500);

            HasMany(x => x.Agendamentos).WithRequired(x => x.Clinica)
                .HasForeignKey(x => x.ClinicaId)
                .WillCascadeOnDelete(false);
        }
    }
}
