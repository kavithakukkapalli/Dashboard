using PatientDashBoard.Models;
using PatientDashBoard.Repository;
using PatientDashBoard.Services.Interface;
using PatientDashBoard.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
namespace PatientDashBoard.Services
{
    public class PatientService : IPatientService
    {
        private readonly IGenericRepository<Patient> _patientRepo;
        private readonly IGenericRepository<Address> _patientAddressRepo;
        public PatientService(IGenericRepository<Patient> patientRepo, IGenericRepository<Address> patientAddressRepo)
        {
            _patientRepo = patientRepo ?? throw new ArgumentNullException(nameof(patientRepo));
            _patientAddressRepo = patientAddressRepo ?? throw new ArgumentNullException(nameof(patientAddressRepo));
        }

        public PatientViewModel GetPatient(int patientId)
        {
            var patient = _patientRepo.GetById(patientId);
            return new PatientViewModel
            {
                PatientId = patient.PatientId,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                NhsNumber = patient.NhsNumber,
                Dob = patient.Dob,
                Email = patient.EMail
            };

        }

        public PatientSummaryViewModel GetSummary(int patientId)
        {
            var patient = _patientRepo.GetById(patientId);
            if (patient == null)
                throw new InvalidOperationException($"No records found for given patient id {patientId}");

            var patientSummary = new PatientSummaryViewModel
            {
                Patient = new PatientViewModel
                {
                    PatientId = patient.PatientId,
                    FirstName = patient.FirstName,
                    LastName = patient.LastName,
                    NhsNumber = patient.NhsNumber,
                    Dob = patient.Dob,
                    Email = patient.EMail
                }
            };


            var patientAddress = _patientAddressRepo.GetWhere(x => x.PatientId == patient.PatientId).FirstOrDefault();
            if (patientAddress != null)
            {

                patientSummary.Address = new PatientAddressViewModel
                {
                    AddressLine1 = patientAddress.AddressLine1,
                    AddressLine2 = patientAddress.AddressLine2,
                    City = patientAddress.City,
                    County = patientAddress.County,
                    PostCode = patientAddress.PostCode,
                };
            }
            return patientSummary;

        }
        public IReadOnlyCollection<PatientViewModel> GetPatients()
        {
            var patient = _patientRepo.GetAll();

            var result = from b in patient
                         where b.Deleted == false
                         select new PatientViewModel
                         {
                             PatientId = b.PatientId,
                             FirstName = b.FirstName,
                             NhsNumber = b.NhsNumber,
                             LastName = b.LastName,
                             Dob = b.Dob,
                             Email = b.EMail
                         };
            return result.ToList();
        }

        public IReadOnlyCollection<PatientViewModel> Search(string search)
        {
            IEnumerable<Patient> patientList = _patientRepo.GetAll();

            if (!string.IsNullOrWhiteSpace(search))
            {
                patientList = patientList.Where(x => x.NhsNumber == search);
            }

            var result = from b in patientList
                         select new PatientViewModel
                         {
                             PatientId = b.PatientId,
                             NhsNumber = b.NhsNumber,
                             FirstName = b.FirstName,
                             LastName = b.LastName,
                             Dob = b.Dob,
                             Email = b.EMail
                         };
            return result.ToList();
        }
    }
}
