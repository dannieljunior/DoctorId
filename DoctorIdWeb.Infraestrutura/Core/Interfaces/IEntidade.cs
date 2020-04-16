using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorIdWeb.Infraestrutura.Core.Interfaces
{
    public interface IEntidade
    {
        Guid Id { get; set; }
        DateTime DtaCadastro { get; set; }
        DateTime? DtaAlteracao { get; set; }
    }
}
