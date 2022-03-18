using System.Collections.Generic;

namespace PatientDashBoard.ViewModel
{
    public class PatientDashboardViewModel
    {
        public PatientDashboardViewModel()
        {
            PatientViewModel = new List<PatientViewModel>();

        }
        public IReadOnlyCollection<PatientViewModel> PatientViewModel { get; set; }
        public string SearchQuery { get; set; }
    }
}
