using DoctorIdWeb.Infraestrutura.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorIdWeb.Infraestrutura.Repository
{
    public class Uow : IUow
    {
        private readonly DoctorIdContext _context;

        public ClinicaRepository Clinica => new ClinicaRepository(_context);
        public ConvenioRepository Convenio => new ConvenioRepository(_context);
        public PacienteRepository Paciente => new PacienteRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public Uow()
        {
            _context = new DoctorIdContext();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public bool Valido()
        {
            throw new NotImplementedException();
        }
    }
}
