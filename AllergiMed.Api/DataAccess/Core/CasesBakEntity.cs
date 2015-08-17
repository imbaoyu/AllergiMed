using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.DataAccess.Core
{
    [Table("AM100_CASES_BAK_050315")]
    public class CasesBakEntity
    {
        [Key]
        [Column("SEQ_CTR")]
        public int SEQ_CTR { get; set; }

        [Required]
        [StringLength(64)]
        [Column("CASE_ID")]
        public string CASE_ID { get; set; }

        [Column("ID")]
        public Guid? ID { get; set; }

        [Column("TS", TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        [Column("INTAKE_DATE", TypeName = "date")]
        public DateTime? INTAKE_DATE { get; set; }

        [Column("EDIT_DATE", TypeName = "date")]
        public DateTime? EDIT_DATE { get; set; }

        [Column("LAST_TEST_DATE", TypeName = "date")]
        public DateTime? LAST_TEST_DATE { get; set; }

        [Column("NEXT_TEST_DATE", TypeName = "date")]
        public DateTime? NEXT_TEST_DATE { get; set; }

        [Column("FIRST_VISIT_DATE", TypeName = "date")]
        public DateTime? FIRST_VISIT_DATE { get; set; }

        [Column("SECOND_VISIT_DATE", TypeName = "date")]
        public DateTime? SECOND_VISIT_DATE { get; set; }

        [Column("THIRD_VISIT_DATE", TypeName = "date")]
        public DateTime? THIRD_VISIT_DATE { get; set; }

        [Column("FOURTH_VISIT_DATE", TypeName = "date")]
        public DateTime? FOURTH_VISIT_DATE { get; set; }

        [Column("RETEST_DATE", TypeName = "date")]
        public DateTime? RETEST_DATE { get; set; }

        [StringLength(20)]
        [Column("TESTKIT_LOT_NUMBER")]
        public string TESTKIT_LOT_NUMBER { get; set; }

        [Column("TESTKIT_LOT_DATE", TypeName = "date")]
        public DateTime? TESTKIT_LOT_DATE { get; set; }

        [Column("FAX_RECD_DATE", TypeName = "date")]
        public DateTime? FAX_RECD_DATE { get; set; }

        [StringLength(32)]
        [Column("DIST_ID")]
        public string DIST_ID { get; set; }

        [StringLength(32)]
        [Column("SUBDIST_ID")]
        public string SUBDIST_ID { get; set; }

        [StringLength(32)]
        [Column("REP_ID")]
        public string REP_ID { get; set; }

        [StringLength(32)]
        [Column("SUBREP_ID")]
        public string SUBREP_ID { get; set; }

        [StringLength(32)]
        [Column("PROVIDER_ID")]
        public string PROVIDER_ID { get; set; }

        [StringLength(1)]
        [Column("PATIENT_DIRECT_FLAG")]
        public string PATIENT_DIRECT_FLAG { get; set; }

        [StringLength(255)]
        [Column("BILLTO_ACCTG_ID")]
        public string BILLTO_ACCTG_ID { get; set; }

        [StringLength(64)]
        [Column("BILLTO_ACCTG_NAME")]
        public string BILLTO_ACCTG_NAME { get; set; }

        [StringLength(64)]
        [Column("BILLTO_ADD1")]
        public string BILLTO_ADD1 { get; set; }

        [StringLength(64)]
        [Column("BILLTO_ADD2")]
        public string BILLTO_ADD2 { get; set; }

        [StringLength(64)]
        [Column("BILLTO_ADD3")]
        public string BILLTO_ADD3 { get; set; }

        [StringLength(64)]
        [Column("BILLTO_ADD4")]
        public string BILLTO_ADD4 { get; set; }

        [StringLength(64)]
        [Column("BILLTO_ADD5")]
        public string BILLTO_ADD5 { get; set; }

        [StringLength(255)]
        [Column("SHIPTO_ACCTG_ID")]
        public string SHIPTO_ACCTG_ID { get; set; }

        [StringLength(64)]
        [Column("SHIPTO_ACCTG_NAME")]
        public string SHIPTO_ACCTG_NAME { get; set; }

        [StringLength(64)]
        [Column("SHIPTO_ADD1")]
        public string SHIPTO_ADD1 { get; set; }

        [StringLength(64)]
        [Column("SHIPTO_ADD2")]
        public string SHIPTO_ADD2 { get; set; }

        [StringLength(64)]
        [Column("SHIPTO_ADD3")]
        public string SHIPTO_ADD3 { get; set; }

        [StringLength(64)]
        [Column("SHIPTO_ADD4")]
        public string SHIPTO_ADD4 { get; set; }

        [StringLength(64)]
        [Column("SHIPTO_ADD5")]
        public string SHIPTO_ADD5 { get; set; }

        [StringLength(32)]
        [Column("SHIPTO_CITY")]
        public string SHIPTO_CITY { get; set; }

        [StringLength(8)]
        [Column("SHIPTO_STATE")]
        public string SHIPTO_STATE { get; set; }

        [StringLength(12)]
        [Column("SHIPTO_POSTAL")]
        public string SHIPTO_POSTAL { get; set; }

        [StringLength(128)]
        [Column("RESULTS_IMAGE_PATH")]
        public string RESULTS_IMAGE_PATH { get; set; }

        [StringLength(32)]
        [Column("RESULTS_IMAGE_FILE")]
        public string RESULTS_IMAGE_FILE { get; set; }

        [StringLength(1)]
        [Column("CONSENT_OK")]
        public string CONSENT_OK { get; set; }

        [StringLength(1)]
        [Column("RX_OK")]
        public string RX_OK { get; set; }

        [StringLength(1)]
        [Column("RESULTS_OK")]
        public string RESULTS_OK { get; set; }

        [StringLength(1)]
        [Column("FINAL_OK")]
        public string FINAL_OK { get; set; }

        [StringLength(32)]
        [Column("PatientLastName")]
        public string PatientLastName { get; set; }

        [StringLength(32)]
        [Column("PatientFirstName")]
        public string PatientFirstName { get; set; }

        [StringLength(1)]
        [Column("PatientMI")]
        public string PatientMI { get; set; }

        [StringLength(70)]
        [Column("PATIENT_NAME")]
        public string PATIENT_NAME { get; set; }

        [StringLength(50)]
        [Column("PatientAddressLine1")]
        public string PatientAddressLine1 { get; set; }

        [StringLength(50)]
        [Column("PatientAddressLine2")]
        public string PatientAddressLine2 { get; set; }

        [StringLength(25)]
        [Column("PatientCity")]
        public string PatientCity { get; set; }

        [StringLength(10)]
        [Column("PatientState")]
        public string PatientState { get; set; }

        [StringLength(12)]
        [Column("PatientZipCode")]
        public string PatientZipCode { get; set; }

        [StringLength(50)]
        [Column("PatientCountry")]
        public string PatientCountry { get; set; }

        [StringLength(25)]
        [Column("PatientBillingAddress")]
        public string PatientBillingAddress { get; set; }

        [StringLength(25)]
        [Column("PatientBillingCity")]
        public string PatientBillingCity { get; set; }

        [StringLength(10)]
        [Column("PatientBillingState")]
        public string PatientBillingState { get; set; }

        [StringLength(10)]
        [Column("PatientBillingZipCode")]
        public string PatientBillingZipCode { get; set; }

        [StringLength(14)]
        [Column("PatientHomePhone")]
        public string PatientHomePhone { get; set; }

        [StringLength(14)]
        [Column("PatientWorkPhone")]
        public string PatientWorkPhone { get; set; }

        [StringLength(14)]
        [Column("PatientFax")]
        public string PatientFax { get; set; }

        [StringLength(64)]
        [Column("PatientEmail")]
        public string PatientEmail { get; set; }

        [StringLength(1)]
        [Column("Gender")]
        public string Gender { get; set; }

        [Column("Birthdate")]
        public DateTime? Birthdate { get; set; }

        [StringLength(10)]
        [Column("AccountNumber")]
        public string AccountNumber { get; set; }

        [StringLength(10)]
        [Column("MedicalRecordNum")]
        public string MedicalRecordNum { get; set; }

        [Column("Notes", TypeName = "ntext")]
        public string Notes { get; set; }

        [Column("ChargeAccount")]
        public bool? ChargeAccount { get; set; }

        [StringLength(32)]
        [Column("PatInsID")]
        public string PatInsID { get; set; }

        [StringLength(25)]
        [Column("SSN")]
        public string SSN { get; set; }

        [StringLength(1)]
        [Column("Spanish")]
        public string Spanish { get; set; }

        [Column("HIPPA")]
        public bool? HIPPA { get; set; }

        [Column("HIPPADATE")]
        public DateTime? HIPPADATE { get; set; }

        [Column("AutoCharge")]
        public bool? AutoCharge { get; set; }

        [Column("FacilityID")]
        public int? FacilityID { get; set; }

        [StringLength(25)]
        [Column("CCNumber")]
        public string CCNumber { get; set; }

        [StringLength(2)]
        [Column("CCExpMonth")]
        public string CCExpMonth { get; set; }

        [StringLength(2)]
        [Column("CCExpYear")]
        public string CCExpYear { get; set; }

        [StringLength(41)]
        [Column("CCName")]
        public string CCName { get; set; }

        [StringLength(41)]
        [Column("CCAddress")]
        public string CCAddress { get; set; }

        [StringLength(41)]
        [Column("CCZip")]
        public string CCZip { get; set; }

        [StringLength(1)]
        [Column("CCAddressSame")]
        public string CCAddressSame { get; set; }

        [Column("DateChanged")]
        public DateTime? DateChanged { get; set; }

        [Column("DateUploaded")]
        public DateTime? DateUploaded { get; set; }

        [Column("BeginBalance")]
        public double? BeginBalance { get; set; }

        [StringLength(50)]
        [Column("Password")]
        public string Password { get; set; }

        [Column("HIPPASignatureID")]
        public int? HIPPASignatureID { get; set; }

        [StringLength(100)]
        [Column("CustomField1")]
        public string CustomField1 { get; set; }

        [StringLength(100)]
        [Column("CustomField2")]
        public string CustomField2 { get; set; }

        [StringLength(100)]
        [Column("CustomField3")]
        public string CustomField3 { get; set; }

        [StringLength(100)]
        [Column("CustomField4")]
        public string CustomField4 { get; set; }

        [StringLength(100)]
        [Column("CustomField5")]
        public string CustomField5 { get; set; }

        [StringLength(100)]
        [Column("CustomField6")]
        public string CustomField6 { get; set; }

        [StringLength(100)]
        [Column("CustomField7")]
        public string CustomField7 { get; set; }

        [StringLength(100)]
        [Column("CustomField8")]
        public string CustomField8 { get; set; }

        [StringLength(100)]
        [Column("CustomField9")]
        public string CustomField9 { get; set; }

        [StringLength(100)]
        [Column("CustomField10")]
        public string CustomField10 { get; set; }

        [StringLength(2)]
        [Column("IDQualifier")]
        public string IDQualifier { get; set; }

        [StringLength(10)]
        [Column("LastRXDate")]
        public string LastRXDate { get; set; }

        [Column("CycleFill")]
        public bool? CycleFill { get; set; }

        [Column("CycleFillInterval")]
        public int? CycleFillInterval { get; set; }

        [Column("RXDuration")]
        public int? RXDuration { get; set; }

        [Column("RXExpDate", TypeName = "date")]
        public DateTime? RXExpDate { get; set; }

        [Column("FirstCycleShipDate", TypeName = "date")]
        public DateTime? FirstCycleShipDate { get; set; }

        [Column("FirstCycleOrder")]
        public int? FirstCycleOrder { get; set; }

        [Column("EndCycleShipDate", TypeName = "date")]
        public DateTime? EndCycleShipDate { get; set; }

        [Column("LastCycleShipDate")]
        public DateTime? LastCycleShipDate { get; set; }

        [Column("LastCycleOrder")]
        public int? LastCycleOrder { get; set; }

        [Column("NextCycleShipDate")]
        public DateTime? NextCycleShipDate { get; set; }

        [Column("NextCycleOrder")]
        public int? NextCycleOrder { get; set; }
    }
}
