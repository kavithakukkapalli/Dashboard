using Autofac;
using PatientDashBoard.Database;

namespace PatientDashBoard.Repository
{
    public class RegisterRepository : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>))
                     .As(typeof(IGenericRepository<>))
                     .InstancePerDependency();          
        }
    }
}
