using DoctorIdWeb.Infraestrutura.Models;
using DoctorIdWeb.Infraestrutura.Repository;

namespace DoctorIdWeb.Infraestrutura.Negocios
{
    public class InformacoesBll
    {
        public InfoModel ObterInformacoes()
        {
            using(var uow = new Uow())
            {
                var info = new InfoModel();
                info.Clinicas  = uow.Clinica.Listar()?.Count ?? 0;
                info.Convenios = uow.Convenio.Listar()?.Count ?? 0;
                return info;
            }
        }
    }
}
