using System;
using System.Web.Mvc;

namespace DoctorIdWeb.Helpers
{
    /// <summary>
    /// aqui um exemplo de um custom helper
    /// </summary>
    public static class HelpersAgenda
    {
        public static MvcHtmlString Card(this HtmlHelper html, DateTime pData, Guid pClinica, 
                                         int pQtdeAgendamentos, bool pCanAgendar, bool pIsFimDeSemana)
        {
            var template = "<div class=\"card\">" + 
                           "<div class=\"content\">" + 
                           "<div class=\"header\">{0}</div>" +
                           "<div class=\"description\">{1}</div></div>" +
                           "<div class=\"ui green {2} attached button btn-novo-agendamento\" data-DataAgenda=\"{3}\" data-Clinica=\"{4}\" >" + 
                           "<i class=\"add icon\"></i>" + 
                           "Agendar</div></div>";

            return new MvcHtmlString(string.Format(template, 
                                                    pData.ToString("dd/MM/yyyy"),
                                                    (pCanAgendar ? $"{pQtdeAgendamentos} agendamentos" : MensagemNaoHaVagas(pIsFimDeSemana)),
                                                    (pCanAgendar ? "" : "disabled"), pData.ToString("dd/MM/yyyy"), pClinica));
        }

        private static string MensagemNaoHaVagas(bool pIsFimdeSemana)
        {
            return string.Format("<div class=\"ui error message\">" +
                                "<div class=\"header\">{0}</div></div>", (pIsFimdeSemana ? "Fim de Semana" : "Não há vagas"));
        }
    }
}