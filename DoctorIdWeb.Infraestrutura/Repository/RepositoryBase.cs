using DoctorIdWeb.Infraestrutura.Core;
using DoctorIdWeb.Infraestrutura.Map;
using DoctorIdWeb.Infraestrutura.ORM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorIdWeb.Infraestrutura.Repository
{
    public abstract class RepositoryBase<T> where T: Entidade
    {
        protected DoctorIdContext _contexto;
        protected abstract DbSet<T> DbSet { get; }
        protected abstract string NomeEntidade { get; }

        public RepositoryBase(DoctorIdContext pContexto)
        {
            _contexto = pContexto;
        }

        public virtual void Incluir(T pEntidade)
        {
            pEntidade.Id = Guid.NewGuid();
            pEntidade.DtaCadastro = DateTime.Now;
            pEntidade.DtaAlteracao = null;
            DbSet.Add(pEntidade);
        }

        public virtual void Alterar(T pEntidade)
        {
            var obj = DbSet.Find(pEntidade.Id);
            pEntidade.DtaCadastro = obj.DtaCadastro;
            pEntidade.MapTo(obj);
            pEntidade.DtaAlteracao = DateTime.Now;
        }

        public virtual void Excluir(T pEntidade)
        {
            DbSet.Remove(DbSet.Find(pEntidade.Id));
        }

        public virtual T Get(Guid Id)
        {
            return DbSet.AsNoTracking()?.FirstOrDefault(x => x.Id == Id);
        }

        public virtual List<T> Listar()
        {
            return DbSet.AsNoTracking().ToList();
        }

        public virtual IQueryable Listar(Func<T, bool> pWhere = null)
        {
            return DbSet.AsNoTracking().Where(pWhere).AsQueryable();
        }
    }
}
