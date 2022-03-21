using PatientDashBoard.ViewModel;
using System.Collections.Generic;

namespace PatientDashBoard.Services.Interface
{
    public interface IPatientService
    {
        IReadOnlyCollection<PatientViewModel> GetPatients();
        PatientViewModel GetPatient(int patientId);
        IReadOnlyCollection<PatientViewModel> Search(string search);
        PatientSummaryViewModel GetSummary(int patientId);
    }
}
