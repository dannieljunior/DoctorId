using DoctorIdWeb.Infraestrutura.Negocios;
using System.Web.Mvc;

namespace DoctorIdWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly InformacoesBll InformacoesBO = new InformacoesBll();

        public ActionResult Index()
        {
            return View(InformacoesBO.ObterInformacoes());
        }
    }
}