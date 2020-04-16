using DoctorIdWeb.Infraestrutura.Core.Interfaces;
using System;

namespace DoctorIdWeb.Infraestrutura.Core
{
    public abstract class Entidade : IEntidade
    {
        public Guid Id { get; set; }
        public DateTime DtaCadastro { get; set; }
        public DateTime? DtaAlteracao { get; set; }
    }
}
