using DoctorIdWeb.Infraestrutura.Models;
using DoctorIdWeb.Infraestrutura.Negocios;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DoctorIdWeb.Controllers
{
    public class ClinicaController : Controller
    {
        /// <summary>
        /// Poderia ser feito por injeção de dependência.
        /// BO: BusinessObject
        /// </summary>
        private readonly ClinicaBll clinicaBO = new ClinicaBll();

        // GET: Clinica
        public ActionResult Index()
        {
            return View(clinicaBO.ObterClinicas());
        }

        [HttpGet]
        public PartialViewResult Incluir()
        {
            return PartialView("Incluir", new ClinicaModel());
        }

        [HttpGet]
        public PartialViewResult Alterar(Guid Id)
        {
            var model = clinicaBO.ObterClinicasPorId(Id);
            return PartialView("Alterar", model);
        }

        [HttpPost]
        public JsonResult Salvar(ClinicaModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new Exception("Erro de validação");
                clinicaBO.IncluirOuAtualizar(model);
                return Json(new { sucesso = true, mensagem = "Registro atualizado com sucesso!" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                var erros = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToArray();
                return Json(new { sucesso = false, mensagens = erros }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}