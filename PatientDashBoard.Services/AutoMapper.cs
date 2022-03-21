using AutoMapper;
using PatientDashBoard.Models;
using PatientDashBoard.ViewModel;

namespace PatientDashBoard.Services
{
    public class AutoMapper : Profile
    {
        public AutoMapper() 
        {
            CreateMap<Patient, PatientViewModel>();
        }       
    }
}
