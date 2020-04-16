using DoctorIdWeb.Infraestrutura.Entidades;
using DoctorIdWeb.Infraestrutura.ORM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DoctorIdWeb.Infraestrutura.Repository
{
    public class PacienteRepository : RepositoryBase<Paciente>
    {
        public PacienteRepository(DoctorIdContext pContexto) : base(pContexto)
        {
        }

        protected override DbSet<Paciente> DbSet => _contexto.Pacientes;

        protected override string NomeEntidade => "Pacientes";

        public override void Alterar(Paciente pEntidade)
        {
            base.Alterar(pEntidade);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override void Excluir(Paciente pEntidade)
        {
            base.Excluir(pEntidade);
        }

        public override Paciente Get(Guid Id)
        {
            return base.Get(Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Incluir(Paciente pEntidade)
        {
            base.Incluir(pEntidade);
        }

        public override List<Paciente> Listar()
        {
            return base.Listar();
        }

        public override IQueryable Listar(Func<Paciente, bool> pWhere = null)
        {
            return base.Listar(pWhere);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
