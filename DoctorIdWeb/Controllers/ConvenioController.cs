using DoctorIdWeb.Infraestrutura.Models;
using DoctorIdWeb.Infraestrutura.Negocios;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DoctorIdWeb.Controllers
{
    public class ConvenioController : Controller
    {
        private readonly ConvenioBll convenioBO = new ConvenioBll();

        // GET: Convenio
        public ActionResult Index()
        {
            return View(convenioBO.ObterConvenios());
        }

        [HttpGet]
        public PartialViewResult Incluir()
        {
            return PartialView("Incluir", new ConvenioModel());
        }

        [HttpGet]
        public PartialViewResult Alterar(Guid Id)
        {
            var model = convenioBO.ObterConvenioPorId(Id);
            return PartialView("Alterar", model);
        }

        [HttpPost]
        public JsonResult Salvar(ConvenioModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new Exception("Erro de validação");
                convenioBO.IncluirOuAtualizar(model);
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