using DoctorIdWeb.Infraestrutura.Entidades;
using DoctorIdWeb.Infraestrutura.ORM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DoctorIdWeb.Infraestrutura.Repository
{
    public class ClinicaRepository : RepositoryBase<Clinica>
    {
        public ClinicaRepository(DoctorIdContext pContexto) : base(pContexto)
        {
        }

        protected override DbSet<Clinica> DbSet => _contexto.Clinicas;

        protected override string NomeEntidade => "Clinicas";

        public override void Alterar(Clinica pEntidade)
        {
            base.Alterar(pEntidade);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override void Excluir(Clinica pEntidade)
        {
            base.Excluir(pEntidade);
        }

        public override Clinica Get(Guid Id)
        {
            return base.Get(Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Incluir(Clinica pEntidade)
        {
            base.Incluir(pEntidade);
        }

        public override List<Clinica> Listar()
        {
            return base.Listar();
        }

        public override IQueryable Listar(Func<Clinica, bool> pWhere = null)
        {
            return base.Listar(pWhere);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
