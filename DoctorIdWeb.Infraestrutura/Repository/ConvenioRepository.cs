using DoctorIdWeb.Infraestrutura.Entidades;
using DoctorIdWeb.Infraestrutura.ORM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DoctorIdWeb.Infraestrutura.Repository
{
    public class ConvenioRepository : RepositoryBase<Convenio>
    {
        public ConvenioRepository(DoctorIdContext pContexto) : base(pContexto)
        {
        }

        protected override DbSet<Convenio> DbSet => _contexto.Convenios;

        protected override string NomeEntidade => "Convenios";

        public override void Alterar(Convenio pEntidade)
        {
            base.Alterar(pEntidade);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override void Excluir(Convenio pEntidade)
        {
            base.Excluir(pEntidade);
        }

        public override Convenio Get(Guid Id)
        {
            return base.Get(Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Incluir(Convenio pEntidade)
        {
            base.Incluir(pEntidade);
        }

        public override List<Convenio> Listar()
        {
            return base.Listar();
        }

        public override IQueryable Listar(Func<Convenio, bool> pWhere = null)
        {
            return base.Listar(pWhere);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
