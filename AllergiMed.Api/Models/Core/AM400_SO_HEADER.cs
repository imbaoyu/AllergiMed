namespace AllergiMed.Api.Models.Case
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AM400_SO_HEADER
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        public int? FK_AM300_SEQ_CTR { get; set; }

        [StringLength(1)]
        public string EXPORTED_TO_ACCTG_FLAG { get; set; }

        [StringLength(64)]
        public string EXPORT_VALIDATION_STATUS { get; set; }

        [StringLength(32)]
        public string SALES_ORDER_NUMBER { get; set; }

        [StringLength(32)]
        public string PURCHASE_ORDER_NUMBER { get; set; }

        [StringLength(1)]
        public string SALES_ORDER_CLOSED_FLAG { get; set; }

        [StringLength(128)]
        public string SALES_ORDER_COMMENTS { get; set; }

        [StringLength(42)]
        public string PRACTITIONER_NAME { get; set; }

        [StringLength(32)]
        public string PROVIDER_ID { get; set; }

        [StringLength(64)]
        public string EMAIL { get; set; }

        [StringLength(1)]
        public string PATIENT_DIRECT_FLAG { get; set; }

        [StringLength(255)]
        public string BILLTO_ACCTG_ID { get; set; }

        [StringLength(34)]
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

        [StringLength(32)]
        public string ORDER_CONF_TEMPLATE { get; set; }

        [StringLength(64)]
        public string SALES_ORDER_TEMPLATE { get; set; }

        [StringLength(32)]
        public string DIST_ID { get; set; }

        [StringLength(6)]
        public string DIST_INITIALS { get; set; }

        [StringLength(32)]
        public string SUBDIST_ID { get; set; }

        [StringLength(32)]
        public string REP_ID { get; set; }

        [StringLength(32)]
        public string SUBREP_ID { get; set; }

        [StringLength(20)]
        public string ORDER_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ORDER_DATE { get; set; }
    }
}
