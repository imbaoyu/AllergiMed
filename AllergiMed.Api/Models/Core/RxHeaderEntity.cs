using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Core
{
    [Table("AM200_RX_HEADER")]
    public class RxHeaderEntity
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public int? FK_AM100_SEQ_CTR { get; set; }

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

        [StringLength(42)]
        public string PRACTITIONER_NAME { get; set; }

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

        [StringLength(1)]
        public string CONSENT_OK { get; set; }

        [StringLength(1)]
        public string RX_OK { get; set; }

        [StringLength(1)]
        public string RESULTS_OK { get; set; }

        [StringLength(1)]
        public string FINAL_OK { get; set; }

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
    }
}
