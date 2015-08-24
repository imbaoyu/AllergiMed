using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using AllergiMed.Api.DataAccess;
using AllergiMed.Api.Models.Core;

namespace AllergiMed.Api.Controllers
{
    [RoutePrefix("api/Patients")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PatientsController : ApiController
    {
        private readonly MedRecordContext _db = new MedRecordContext();

        [Authorize]
        [HttpGet]
        [Route("")]
        public IEnumerable<PatientModel> GetPatients()
        {
            var patients = from p in _db.CasesEntity
                select new PatientModel
                {
                    PatientLastName = p.PatientLastName,
                    PatientFirstName = p.PatientFirstName,
                    PatientMi = p.PatientMi,
                    PatientName = p.PatientName,

                    PatientAddressLine1 = p.PatientAddressLine1,
                    PatientAddressLine2 = p.PatientAddressLine2,
                    PatientCity = p.PatientCity,
                    PatientState = p.PatientState,
                    PatientZipCode = p.PatientZipCode,
                    PatientCountry = p.PatientCountry,
                    PatientBillingAddress = p.PatientBillingAddress,
                    PatientBillingCity = p.PatientBillingCity,
                    PatientBillingState = p.PatientBillingState,
                    PatientBillingZipCode = p.PatientBillingZipCode,
                    
                    PatientHomePhone = p.PatientHomePhone,
                    PatientWorkPhone = p.PatientWorkPhone,
                    PatientFax = p.PatientFax,
                    PatientEmail = p.PatientEmail,

                    Gender = p.Gender,
                    Birthdate = p.Birthdate,
                    AccountNumber = p.AccountNumber,
                    MedicalRecordNum = p.MedicalRecordNum,

                    Notes = p.Notes,
                    ChargeAccount = p.ChargeAccount,
                    PatInsId = p.PatInsId,
                    Ssn = p.Ssn,
                    Spanish = p.Spanish
                };

            return patients.AsEnumerable();
        }

        [Authorize]
        [HttpPost]
        [Route("")]
        public PatientModel CreatePatient(PatientModel patient)
        {
            return new PatientModel
            {

            };
        }

    }
}


