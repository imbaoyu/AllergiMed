using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Core
{
    [Table("AM100_CASES")]
    public class CasesEntity
    {
        [Key]
        [Column("SEQ_CTR")]
        public int SeqCtr { get; set; }

        [Required]
        [StringLength(64)]
        [Column("CASE_ID")]
        public string CaseId { get; set; }

        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("TS", TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TimeStamp { get; set; }

        [Column("INTAKE_DATE", TypeName = "date")]
        public DateTime? IntakeDate { get; set; }

        [Column("EDIT_DATE", TypeName = "date")]
        public DateTime? EditDate { get; set; }

        [Column("LAST_TEST_DATE", TypeName = "date")]
        public DateTime? LastTestDate { get; set; }

        [Column("NEXT_TEST_DATE", TypeName = "date")]
        public DateTime? NextTestDate { get; set; }

        [Column("FIRST_VISIT_DATE", TypeName = "date")]
        public DateTime? FirstVisitDate { get; set; }

        [Column("SECOND_VISIT_DATE", TypeName = "date")]
        public DateTime? SecondVisitDate { get; set; }

        [Column("THIRD_VISIT_DATE", TypeName = "date")]
        public DateTime? ThirdVisitDate { get; set; }

        [Column("FOURTH_VISIT_DATE", TypeName = "date")]
        public DateTime? FourthVisitDate { get; set; }

        [Column("RETEST_DATE", TypeName = "date")]
        public DateTime? RetestDate { get; set; }

        [StringLength(20)]
        [Column("TESTKIT_LOT_NUMBER")]
        public string TestkitLotNumber { get; set; }

        [Column("TESTKIT_LOT_DATE", TypeName = "date")]
        public DateTime? TestkitLotDate { get; set; }

        [Column("FAX_RECD_DATE", TypeName = "date")]
        public DateTime? FaxRecdDate { get; set; }

        [StringLength(32)]
        [Column("DIST_ID")]
        public string DistId { get; set; }

        [StringLength(32)]
        [Column("SUBDIST_ID")]
        public string SubdistId { get; set; }

        [StringLength(32)]
        [Column("REP_ID")]
        public string RepId { get; set; }

        [StringLength(32)]
        [Column("SUBREP_ID")]
        public string SubrepId { get; set; }

        [StringLength(32)]
        [Column("PROVIDER_ID")]
        public string ProviderId { get; set; }

        [StringLength(1)]
        [Column("PATIENT_DIRECT_FLAG")]
        public string PatientDirectFlag { get; set; }

        [StringLength(255)]
        [Column("BILLTO_ACCTG_ID")]
        public string BilltoAcctgId { get; set; }

        [StringLength(64)]
        [Column("BILLTO_ACCTG_NAME")]
        public string BilltoAcctgName { get; set; }

        [StringLength(64)]
        [Column("BILLTO_ADD1")]
        public string BilltoAdd1 { get; set; }

        [StringLength(64)]
        [Column("BILLTO_ADD2")]
        public string BilltoAdd2 { get; set; }

        [StringLength(64)]
        [Column("BILLTO_ADD3")]
        public string BilltoAdd3 { get; set; }

        [StringLength(64)]
        [Column("BILLTO_ADD4")]
        public string BilltoAdd4 { get; set; }

        [StringLength(64)]
        [Column("BILLTO_ADD5")]
        public string BilltoAdd5 { get; set; }

        [StringLength(255)]
        [Column("SHIPTO_ACCTG_ID")]
        public string ShiptoAcctgId { get; set; }

        [StringLength(64)]
        [Column("SHIPTO_ACCTG_NAME")]
        public string ShiptoAcctgName { get; set; }

        [StringLength(64)]
        [Column("SHIPTO_ADD1")]
        public string ShiptoAdd1 { get; set; }

        [StringLength(64)]
        [Column("SHIPTO_ADD2")]
        public string ShiptoAdd2 { get; set; }

        [StringLength(64)]
        [Column("SHIPTO_ADD3")]
        public string ShiptoAdd3 { get; set; }

        [StringLength(64)]
        [Column("SHIPTO_ADD4")]
        public string ShiptoAdd4 { get; set; }

        [StringLength(64)]
        [Column("SHIPTO_ADD5")]
        public string ShiptoAdd5 { get; set; }

        [StringLength(32)]
        [Column("SHIPTO_CITY")]
        public string ShiptoCity { get; set; }

        [StringLength(8)]
        [Column("SHIPTO_STATE")]
        public string ShiptoState { get; set; }

        [StringLength(12)]
        [Column("SHIPTO_POSTAL")]
        public string ShiptoPostal { get; set; }

        [StringLength(128)]
        [Column("RESULTS_IMAGE_PATH")]
        public string ResultsImagePath { get; set; }

        [StringLength(32)]
        [Column("RESULTS_IMAGE_FILE")]
        public string ResultsImageFile { get; set; }

        [StringLength(1)]
        [Column("CONSENT_OK")]
        public string ConsentOk { get; set; }

        [StringLength(1)]
        [Column("RX_OK")]
        public string RxOk { get; set; }

        [StringLength(1)]
        [Column("RESULTS_OK")]
        public string ResultsOk { get; set; }

        [StringLength(1)]
        [Column("FINAL_OK")]
        public string FinalOk { get; set; }

        [StringLength(32)]
        [Column("PatientLastName")]
        public string PatientLastName { get; set; }

        [StringLength(32)]
        [Column("PatientFirstName")]
        public string PatientFirstName { get; set; }

        [StringLength(1)]
        [Column("PatientMI")]
        public string PatientMi { get; set; }

        [StringLength(70)]
        [Column("PATIENT_NAME")]
        public string PatientName { get; set; }

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
        public string PatInsId { get; set; }

        [StringLength(25)]
        [Column("SSN")]
        public string Ssn { get; set; }

        [StringLength(1)]
        [Column("Spanish")]
        public string Spanish { get; set; }

        [Column("HIPPA")]
        public bool? Hippa { get; set; }

        [Column("HIPPA")]
        public DateTime? HippaDate { get; set; }

        [Column("AutoCharge")]
        public bool? AutoCharge { get; set; }

        [Column("FacilityID")]
        public int? FacilityId { get; set; }

        [StringLength(25)]
        [Column("CCNumber")]
        public string CcNumber { get; set; }

        [StringLength(2)]
        [Column("CCExpMonth")]
        public string CcExpMonth { get; set; }

        [StringLength(2)]
        [Column("CCExpYear")]
        public string CcExpYear { get; set; }

        [StringLength(41)]
        [Column("CCName")]
        public string CcName { get; set; }

        [StringLength(41)]
        [Column("CCAddress")]
        public string CcAddress { get; set; }

        [StringLength(41)]
        [Column("CCZip")]
        public string CcZip { get; set; }

        [StringLength(1)]
        [Column("CCAddressSame")]
        public string CcAddressSame { get; set; }

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
        public int? HippaSignatureId { get; set; }

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
        public string IdQualifier { get; set; }

        [StringLength(10)]
        [Column("LastRXDate")]
        public string LastRxDate { get; set; }

        [Column("CycleFill")]
        public bool? CycleFill { get; set; }

        [Column("CycleFillInterval")]
        public int? CycleFillInterval { get; set; }

        [Column("RXDuration")]
        public int? RxDuration { get; set; }

        [Column("RXExpDate", TypeName = "date")]
        public DateTime? RxExpDate { get; set; }

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
