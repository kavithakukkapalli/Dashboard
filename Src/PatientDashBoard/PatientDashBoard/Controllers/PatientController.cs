using PatientDashBoard.Services.Interface;
using PatientDashBoard.ViewModel;
using System;
using System.Web.Mvc;


namespace PatientDashBoard.Controllers
{
    [Route("patient")]
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService ?? throw new ArgumentNullException(nameof(patientService));
        }


        public ActionResult Index()
        {
            ViewBag.hasError = false;
            var result = _patientService.GetPatients();
            return View(new PatientDashboardViewModel
            {
                PatientViewModel = result
            });
        }

        [HttpPost]
        public ActionResult Index(string searchQuery)
        {
            ViewBag.hasError = false;
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                ViewBag.hasError = true;
                return View(new PatientDashboardViewModel());
            }
            var result = _patientService.Search(searchQuery);
            return View(new PatientDashboardViewModel
            {
                PatientViewModel = result,
                SearchQuery = searchQuery
            });
        }

        public ActionResult Details(int id)
        {
            var result = _patientService.GetSummary(id);
            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}