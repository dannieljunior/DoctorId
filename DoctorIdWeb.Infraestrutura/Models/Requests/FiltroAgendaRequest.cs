using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorIdWeb.Infraestrutura.Models.Requests
{
    public class FiltroAgendaRequest
    {
        public Guid Clinica { get; set; }
        public DateTime DtaInicio { get; set; }
        public DateTime DtaFinal { get; set; }
    }
}
