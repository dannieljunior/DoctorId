using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorIdWeb.Infraestrutura.Repository
{
    /// <summary>
    /// Unit of Work
    /// </summary>
    public interface IUow: IDisposable
    {
        ClinicaRepository Clinica { get; }
        bool Valido();
        void Salvar();
    }
}
