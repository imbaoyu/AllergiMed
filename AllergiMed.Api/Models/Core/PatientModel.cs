using System;

namespace AllergiMed.Api.Models.Core
{
    //case
    public class PatientModel
    {
        public string PatientLastName { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMi { get; set; }
        public string PatientName { get; set; }

        public string PatientAddressLine1 { get; set; }
        public string PatientAddressLine2 { get; set; }
        public string PatientCity { get; set; }
        public string PatientState { get; set; }
        public string PatientZipCode { get; set; }
        public string PatientCountry { get; set; }

        public string PatientBillingAddress { get; set; }
        public string PatientBillingCity { get; set; }
        public string PatientBillingState { get; set; }
        public string PatientBillingZipCode { get; set; }

        public string PatientHomePhone { get; set; }
        public string PatientWorkPhone { get; set; }
        public string PatientFax { get; set; }
        public string PatientEmail { get; set; }

        public string Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public string AccountNumber { get; set; }
        public string MedicalRecordNum { get; set; }

        public string Notes { get; set; }
        public bool? ChargeAccount { get; set; }
        public string PatInsId { get; set; }
        
        public string Ssn { get; set; }

        public string Spanish { get; set; }
    }
}