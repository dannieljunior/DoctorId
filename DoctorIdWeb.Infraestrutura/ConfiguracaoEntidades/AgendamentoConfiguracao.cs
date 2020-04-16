using DoctorIdWeb.Infraestrutura.Core;
using DoctorIdWeb.Infraestrutura.Entidades;

namespace DoctorIdWeb.Infraestrutura.ConfiguracaoEntidades
{
    public class AgendamentoConfiguracao: EntidadeConfiguracao<Agendamento>
    {
        public AgendamentoConfiguracao()
        {
            ToTable("Agendamentos");
        }
    }
}
