using DoctorIdWeb.Infraestrutura.Entidades;
using DoctorIdWeb.Infraestrutura.Map;
using DoctorIdWeb.Infraestrutura.Models;
using DoctorIdWeb.Infraestrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoctorIdWeb.Infraestrutura.Negocios
{
    public class PacienteBll
    {
        public List<PacienteModel> ObterPacientes()
        {
            using(var uow = new Uow())
            {
                return uow.Paciente.Listar().MapEachTo<PacienteModel>().ToList();
            }
        }

        public PacienteModel ObterPacientePorCnpj(string pCpf)
        {
            using (var uow = new Uow())
            {
                return uow.Paciente.Listar().FirstOrDefault(x => x.Cpf.Equals(pCpf))?.MapTo<PacienteModel>();
            }
        }

        public PacienteModel ObterPacienteClinicasPorId(Guid pId)
        {
            using (var uow = new Uow())
            {
                return uow.Paciente.Get(pId)?.MapTo<PacienteModel>();
            }
        }

        public void IncluirOuAtualizar(PacienteModel pPaciente)
        {
            try
            {
                using (var uow = new Uow())
                {
                    var objExistente = uow.Paciente.Get(pPaciente.Id)?.MapTo<PacienteModel>();
                    if (objExistente == null)
                        uow.Paciente.Incluir(pPaciente.MapTo<Paciente>());
                    else
                        uow.Paciente.Alterar(pPaciente.MapTo<Paciente>());

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
