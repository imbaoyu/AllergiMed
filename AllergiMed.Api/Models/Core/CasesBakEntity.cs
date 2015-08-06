using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Core
{
    [Table("AM100_CASES_BAK_050315")]
    public class CasesBakEntity
    {
        [Key]
        public int SEQ_CTR { get; set; }

        [Required]
        [StringLength(64)]
        public string CASE_ID { get; set; }

        public Guid? ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? INTAKE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EDIT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_TEST_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NEXT_TEST_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FIRST_VISIT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SECOND_VISIT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? THIRD_VISIT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FOURTH_VISIT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RETEST_DATE { get; set; }

        [StringLength(20)]
        public string TESTKIT_LOT_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TESTKIT_LOT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FAX_RECD_DATE { get; set; }

        [StringLength(32)]
        public string DIST_ID { get; set; }

        [StringLength(32)]
        public string SUBDIST_ID { get; set; }

        [StringLength(32)]
        public string REP_ID { get; set; }

        [StringLength(32)]
        public string SUBREP_ID { get; set; }

        [StringLength(32)]
        public string PROVIDER_ID { get; set; }

        [StringLength(1)]
        public string PATIENT_DIRECT_FLAG { get; set; }

        [StringLength(255)]
        public string BILLTO_ACCTG_ID { get; set; }

        [StringLength(64)]
        public string BILLTO_ACCTG_NAME { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD1 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD2 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD3 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD4 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD5 { get; set; }

        [StringLength(255)]
        public string SHIPTO_ACCTG_ID { get; set; }

        [StringLength(64)]
        public string SHIPTO_ACCTG_NAME { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD1 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD2 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD3 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD4 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD5 { get; set; }

        [StringLength(32)]
        public string SHIPTO_CITY { get; set; }

        [StringLength(8)]
        public string SHIPTO_STATE { get; set; }

        [StringLength(12)]
        public string SHIPTO_POSTAL { get; set; }

        [StringLength(128)]
        public string RESULTS_IMAGE_PATH { get; set; }

        [StringLength(32)]
        public string RESULTS_IMAGE_FILE { get; set; }

        [StringLength(1)]
        public string CONSENT_OK { get; set; }

        [StringLength(1)]
        public string RX_OK { get; set; }

        [StringLength(1)]
        public string RESULTS_OK { get; set; }

        [StringLength(1)]
        public string FINAL_OK { get; set; }

        [StringLength(32)]
        public string PatientLastName { get; set; }

        [StringLength(32)]
        public string PatientFirstName { get; set; }

        [StringLength(1)]
        public string PatientMI { get; set; }

        [StringLength(70)]
        public string PATIENT_NAME { get; set; }

        [StringLength(50)]
        public string PatientAddressLine1 { get; set; }

        [StringLength(50)]
        public string PatientAddressLine2 { get; set; }

        [StringLength(25)]
        public string PatientCity { get; set; }

        [StringLength(10)]
        public string PatientState { get; set; }

        [StringLength(12)]
        public string PatientZipCode { get; set; }

        [StringLength(50)]
        public string PatientCountry { get; set; }

        [StringLength(25)]
        public string PatientBillingAddress { get; set; }

        [StringLength(25)]
        public string PatientBillingCity { get; set; }

        [StringLength(10)]
        public string PatientBillingState { get; set; }

        [StringLength(10)]
        public string PatientBillingZipCode { get; set; }

        [StringLength(14)]
        public string PatientHomePhone { get; set; }

        [StringLength(14)]
        public string PatientWorkPhone { get; set; }

        [StringLength(14)]
        public string PatientFax { get; set; }

        [StringLength(64)]
        public string PatientEmail { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        public DateTime? Birthdate { get; set; }

        [StringLength(10)]
        public string AccountNumber { get; set; }

        [StringLength(10)]
        public string MedicalRecordNum { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool? ChargeAccount { get; set; }

        [StringLength(32)]
        public string PatInsID { get; set; }

        [StringLength(25)]
        public string SSN { get; set; }

        [StringLength(1)]
        public string Spanish { get; set; }

        public bool? HIPPA { get; set; }

        public DateTime? HIPPADATE { get; set; }

        public bool? AutoCharge { get; set; }

        public int? FacilityID { get; set; }

        [StringLength(25)]
        public string CCNumber { get; set; }

        [StringLength(2)]
        public string CCExpMonth { get; set; }

        [StringLength(2)]
        public string CCExpYear { get; set; }

        [StringLength(41)]
        public string CCName { get; set; }

        [StringLength(41)]
        public string CCAddress { get; set; }

        [StringLength(41)]
        public string CCZip { get; set; }

        [StringLength(1)]
        public string CCAddressSame { get; set; }

        public DateTime? DateChanged { get; set; }

        public DateTime? DateUploaded { get; set; }

        public double? BeginBalance { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? HIPPASignatureID { get; set; }

        [StringLength(100)]
        public string CustomField1 { get; set; }

        [StringLength(100)]
        public string CustomField2 { get; set; }

        [StringLength(100)]
        public string CustomField3 { get; set; }

        [StringLength(100)]
        public string CustomField4 { get; set; }

        [StringLength(100)]
        public string CustomField5 { get; set; }

        [StringLength(100)]
        public string CustomField6 { get; set; }

        [StringLength(100)]
        public string CustomField7 { get; set; }

        [StringLength(100)]
        public string CustomField8 { get; set; }

        [StringLength(100)]
        public string CustomField9 { get; set; }

        [StringLength(100)]
        public string CustomField10 { get; set; }

        [StringLength(2)]
        public string IDQualifier { get; set; }

        [StringLength(10)]
        public string LastRXDate { get; set; }

        public bool? CycleFill { get; set; }

        public int? CycleFillInterval { get; set; }

        public int? RXDuration { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RXExpDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FirstCycleShipDate { get; set; }

        public int? FirstCycleOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndCycleShipDate { get; set; }

        public DateTime? LastCycleShipDate { get; set; }

        public int? LastCycleOrder { get; set; }

        public DateTime? NextCycleShipDate { get; set; }

        public int? NextCycleOrder { get; set; }
    }
}
