using AutoMapper;
using DoctorIdWeb.Infraestrutura.Core;
using DoctorIdWeb.Infraestrutura.Entidades;
using DoctorIdWeb.Infraestrutura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorIdWeb.Infraestrutura.Map
{
    public class MapModelToEntidade
    {
        public MapModelToEntidade()
        {
            Mapper.CreateMap<ModelBase, Entidade>()
                .Include<ClinicaModel, Clinica>()
                .Include<ConvenioModel, Convenio>()
                .Include<PacienteModel, Paciente>()
                .Include<AgendamentoModel, Agendamento>();

            Mapper.CreateMap<ClinicaModel, Clinica>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore());
            Mapper.CreateMap<ConvenioModel, Convenio>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore());
            Mapper.CreateMap<PacienteModel, Paciente>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore());
            Mapper.CreateMap<AgendamentoModel, Agendamento>()
                .ForMember(x => x.Paciente, opt => opt.Ignore())
                .ForMember(x => x.Clinica, opt => opt.Ignore())
                .ForMember(x => x.Convenio, opt => opt.Ignore());
        }
    }
}
