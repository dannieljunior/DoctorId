using DoctorIdWeb.Infraestrutura.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorIdWeb.Controllers
{
    public class PacienteController : Controller
    {
        private readonly PacienteBll PacienteBO = new PacienteBll();

        // GET: Paciente
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ConsultaCpf(string cpf)
        {
            var paciente = PacienteBO.ObterPacientePorCnpj(cpf);
            return Json(paciente, JsonRequestBehavior.AllowGet);
        }
    }
}