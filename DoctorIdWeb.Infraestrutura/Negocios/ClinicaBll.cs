using DoctorIdWeb.Infraestrutura.Entidades;
using DoctorIdWeb.Infraestrutura.Map;
using DoctorIdWeb.Infraestrutura.Models;
using DoctorIdWeb.Infraestrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoctorIdWeb.Infraestrutura.Negocios
{
    public class ClinicaBll
    {
        public List<ClinicaModel> ObterClinicas()
        {
            using(var uow = new Uow())
            {
                return uow.Clinica.Listar().MapEachTo<ClinicaModel>().ToList();
            }
        }

        public ClinicaModel ObterClinicasPorId(Guid pId)
        {
            using (var uow = new Uow())
            {
                return uow.Clinica.Get(pId)?.MapTo<ClinicaModel>();
            }
        }

        public void IncluirOuAtualizar(ClinicaModel pClinica)
        {
            try
            {
                using (var uow = new Uow())
                {
                    var objExistente = uow.Clinica.Get(pClinica.Id)?.MapTo<ClinicaModel>();
                    if (objExistente == null)
                        uow.Clinica.Incluir(pClinica.MapTo<Clinica>());
                    else
                        uow.Clinica.Alterar(pClinica.MapTo<Clinica>());

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
