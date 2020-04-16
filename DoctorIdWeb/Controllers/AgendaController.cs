using DoctorIdWeb.Infraestrutura.Models;
using DoctorIdWeb.Infraestrutura.Models.Requests;
using DoctorIdWeb.Infraestrutura.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorIdWeb.Controllers
{
    public class AgendaController : Controller
    {
        private readonly ClinicaBll ClinicaBO = new ClinicaBll();
        private readonly ConvenioBll ConvenioBO = new ConvenioBll();
        private readonly AgendamentoBll AgendamentoBO = new AgendamentoBll();

        // GET: Agenda
        [HttpGet]
        public ActionResult Index()
        {
            ObterListas();
            return View(new List<AgendamentoModel>());
        }

        [HttpPost]
        public PartialViewResult Index(FiltroAgendaRequest filtro)
        {
            return PartialView("Lista", AgendamentoBO.ObterAgenda(filtro));
        }

        /// <summary>
        /// Como eu mencionei na view, eu teria várias opções para fazer-lo! Optei pela mais rápida e eficaz
        /// </summary>
        private void ObterListas()
        {
            ViewData["SelectClinicas"] = new SelectList(ClinicaBO.ObterClinicas().ToList(), "Id", "Nome", null);
        }

        private void ObterConvenios()
        {
            ViewData["SelectConvenios"] = new SelectList(ConvenioBO.ObterConvenios().ToList(), "Id", "Nome", null);
        }

        [HttpPost]
        public PartialViewResult Incluir(NovoAgendamentoRequest request)
        {
            var clinica = ClinicaBO.ObterClinicasPorId(request.ClinicaId);
            var novoRegistroAgenda = new AgendamentoModel
            {
                Data = request.Data,
                ClinicaId  = clinica.Id,
                ClinicaNome = clinica.Nome
            };

            ObterConvenios();

            return PartialView("Incluir", novoRegistroAgenda);
        }
    }
}