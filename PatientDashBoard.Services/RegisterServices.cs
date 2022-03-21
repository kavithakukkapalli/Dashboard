using Autofac;
using PatientDashBoard.Repository;
using PatientDashBoard.Services.Interface;

namespace PatientDashBoard.Services
{
    public class RegisterServices : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PatientService>().As<IPatientService>().InstancePerRequest();

            builder.RegisterModule(new RegisterRepository());
            
            base.Load(builder);
        }
    }
}
