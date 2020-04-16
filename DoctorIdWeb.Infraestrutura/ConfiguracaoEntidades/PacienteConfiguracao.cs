using DoctorIdWeb.Infraestrutura.Core;
using DoctorIdWeb.Infraestrutura.Entidades;

namespace DoctorIdWeb.Infraestrutura.ConfiguracaoEntidades
{
    public class PacienteConfiguracao: EntidadeConfiguracao<Paciente>
    {
        public PacienteConfiguracao()
        {
            ToTable("Pacientes");
            Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(200);
            Property(x => x.Cpf).HasColumnType("varchar").HasMaxLength(11);
            Property(x => x.Email).HasColumnType("varchar").HasMaxLength(200);
            Property(x => x.Telefone).HasColumnType("varchar").HasMaxLength(20);

            HasMany(x => x.Agendamentos).WithRequired(x => x.Paciente)
                .HasForeignKey(x => x.PacienteId)
                .WillCascadeOnDelete(false);
        }
    }
}
