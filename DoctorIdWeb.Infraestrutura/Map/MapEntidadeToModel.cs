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
    public class MapEntidadeToModel
    {
        public MapEntidadeToModel()
        {
            Mapper.CreateMap<Entidade, ModelBase>()
                .Include<Clinica, ClinicaModel>()
                .Include<Convenio, ConvenioModel>()
                .Include<Paciente, PacienteModel>()
                .Include<Agendamento, AgendamentoModel>();

            Mapper.CreateMap<Clinica, ClinicaModel>();
            Mapper.CreateMap<Convenio, ConvenioModel>();
            Mapper.CreateMap<Paciente, PacienteModel>();
            Mapper.CreateMap<Agendamento, AgendamentoModel>()
                .ForMember(x => x.ClinicaNome, opt => opt.Ignore())
                .ForMember(x => x.Nome, opt => opt.Ignore())
                .ForMember(x => x.Cpf, opt => opt.Ignore())
                .ForMember(x => x.Telefone, opt => opt.Ignore())
                .ForMember(x => x.EMail, opt => opt.Ignore());


        }
    }
}
