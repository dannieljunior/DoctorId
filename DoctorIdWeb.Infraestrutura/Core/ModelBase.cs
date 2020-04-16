using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorIdWeb.Infraestrutura.Core
{
    public abstract class ModelBase
    {
        public Guid Id { get; set; }
        public DateTime DtaCadastro { get; set; }
        public DateTime? DtaAlteracao { get; set; }
    }
}
