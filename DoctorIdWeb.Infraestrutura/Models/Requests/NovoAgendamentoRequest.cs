using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorIdWeb.Infraestrutura.Models.Requests
{
    public class NovoAgendamentoRequest
    {
        public DateTime Data { get; set; }
        public Guid ClinicaId { get; set; }
    }
}
