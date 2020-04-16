using AutoMapper;
using DoctorIdWeb.Infraestrutura.Core;
using DoctorIdWeb.Infraestrutura.Entidades;

namespace DoctorIdWeb.Infraestrutura.Map
{
    public class MapEntidadeToEntidade
    {
        public MapEntidadeToEntidade()
        {
            Mapper.CreateMap<Entidade, Entidade>()
                .Include<Clinica, Clinica>()
                .Include<Convenio, Convenio>()
                .Include<Paciente, Paciente>()
                .Include<Agendamento, Agendamento>();

            Mapper.CreateMap<Clinica, Clinica>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore());
            Mapper.CreateMap<Convenio, Convenio>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore());
            Mapper.CreateMap<Paciente, Paciente>()
                .ForMember(x => x.Agendamentos, opt => opt.Ignore());
            Mapper.CreateMap<Agendamento, Agendamento>()
                .ForMember(x => x.Paciente, opt => opt.Ignore())
                .ForMember(x => x.Clinica, opt => opt.Ignore())
                .ForMember(x => x.Convenio, opt => opt.Ignore());
        }
    }
}
