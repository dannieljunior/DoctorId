using DoctorIdWeb.Infraestrutura.Core;
using DoctorIdWeb.Infraestrutura.Migrations;
using System;
using config = System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using DoctorIdWeb.Infraestrutura.Entidades;

namespace DoctorIdWeb.Infraestrutura.ORM
{
    public class DoctorIdContext: DbContext
    {
        public DoctorIdContext(): base(config.ConfigurationManager.AppSettings["ambiente"])
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DoctorIdContext, Configuration>());
        }

        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Convenio> Convenios { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Executar as classes de configuração de entidades

            var addMethod = typeof(ConfigurationRegistrar)
                               .GetMethods()
                               .Single(m =>
                                m.Name == "Add"
                                && m.GetGenericArguments().Any(a => a.Name == "TEntityType"));

            foreach (var assembly in AppDomain.CurrentDomain
                .GetAssemblies()
                .Where(a => a.GetName().Name != "EntityFramework"))
            {
                var configTypes = assembly
                 .GetTypes()
                 .Where(t => t.BaseType != null
                  && t.BaseType.IsGenericType
                  && t.BaseType.GetGenericTypeDefinition() == typeof(EntidadeConfiguracao<>));

                foreach (var type in configTypes)
                {
                    var entityType = type.BaseType.GetGenericArguments().Single();

                    var entityConfig = assembly.CreateInstance(type.FullName);
                    addMethod.MakeGenericMethod(entityType)
                     .Invoke(modelBuilder.Configurations, new object[] { entityConfig });
                }
            }
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
