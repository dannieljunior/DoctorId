using DoctorIdWeb.Infraestrutura.Core;
using System.Collections.Generic;

namespace DoctorIdWeb.Infraestrutura.Entidades

{
    public class Convenio: Entidade
    {
        public string Nome { get; set; }

        public List<Agendamento> Agendamentos { get; set; }
    }
}
