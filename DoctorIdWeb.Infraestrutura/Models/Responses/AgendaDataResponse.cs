using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorIdWeb.Infraestrutura.Models.Responses
{
    /// <summary>
    /// as classes de response podem ser interpretadas nesta micro arquitetura com o papel de  ViewModels
    /// </summary>
    public class AgendaDataResponse
    {
        /// <summary>
        /// Num sistema real, haveria uma parametrização de dias úteis, 
        /// feriados e etc. So pra mostrar que eu pensei nisso (rsrs)
        /// </summary>
        private DayOfWeek[] FimDeSemana = new[] { DayOfWeek.Saturday, DayOfWeek.Sunday };
        public DateTime Data { get; set; }
        public ClinicaModel Clinica { get; set; }
        public int QtdeAgendamentos { get; set; }
        public bool CanAdicionarAgendamentos => QtdeAgendamentos < 20 && !IsFimDeSemana;
        public bool IsFimDeSemana => FimDeSemana.Contains(Data.DayOfWeek);
    }
}
