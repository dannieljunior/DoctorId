using DoctorIdWeb.Infraestrutura.Core;
using DoctorIdWeb.Infraestrutura.Entidades;

namespace DoctorIdWeb.Infraestrutura.ConfiguracaoEntidades
{
    public class ConvenioConfiguracao: EntidadeConfiguracao<Convenio>
    {
        public ConvenioConfiguracao()
        {
            ToTable("Convenios");
            Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(200);

            HasMany(x => x.Agendamentos).WithOptional(x => x.Convenio)
                .HasForeignKey(x => x.ConvenioId)
                .WillCascadeOnDelete(false);
        }
    }
}
