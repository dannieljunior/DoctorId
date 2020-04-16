using DoctorIdWeb.Infraestrutura.Models.Requests;
using DoctorIdWeb.Infraestrutura.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorIdWeb.Infraestrutura.Negocios
{
    public class AgendamentoBll
    {
        public List<AgendaDataResponse> ObterAgenda(FiltroAgendaRequest pFiltro)
        {
            var data = pFiltro.DtaInicio;
            var agenda = new List<AgendaDataResponse>();
            var objClinica = new ClinicaBll().ObterClinicasPorId(pFiltro.Clinica);
            while (data.Date <= pFiltro.DtaFinal.Date)
            {
                agenda.Add(new AgendaDataResponse()
                {
                    Clinica = objClinica,
                    QtdeAgendamentos = 0,
                    Data = data.Date
                });

                data = data.AddDays(1);
            }

            return agenda;

        }
    }
}
