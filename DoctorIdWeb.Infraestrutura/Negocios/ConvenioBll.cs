using DoctorIdWeb.Infraestrutura.Entidades;
using DoctorIdWeb.Infraestrutura.Map;
using DoctorIdWeb.Infraestrutura.Models;
using DoctorIdWeb.Infraestrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoctorIdWeb.Infraestrutura.Negocios
{
    public class ConvenioBll
    {
        public List<ConvenioModel> ObterConvenios()
        {
            using(var uow = new Uow())
            {
                return uow.Convenio.Listar().MapEachTo<ConvenioModel>().ToList();
            }
        }

        public ConvenioModel ObterConvenioPorId(Guid pId)
        {
            using (var uow = new Uow())
            {
                return uow.Convenio.Get(pId)?.MapTo<ConvenioModel>();
            }
        }

        public void IncluirOuAtualizar(ConvenioModel pClinica)
        {
            try
            {
                using (var uow = new Uow())
                {
                    var objExistente = uow.Convenio.Get(pClinica.Id)?.MapTo<ConvenioModel>();
                    if (objExistente == null)
                        uow.Convenio.Incluir(pClinica.MapTo<Convenio>());
                    else
                        uow.Convenio.Alterar(pClinica.MapTo<Convenio>());

                    uow.Salvar();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
