using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorIdWeb.Infraestrutura.Core
{
    public abstract class EntidadeConfiguracao<T>: EntityTypeConfiguration<T> where T: Entidade
    {
    }
}
