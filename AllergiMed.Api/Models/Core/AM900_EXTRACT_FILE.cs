namespace AllergiMed.Api.Models.Case
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AM900_EXTRACT_FILE
    {
        [Key]
        public int SEQ_CTR { get; set; }

        [Required]
        [StringLength(64)]
        public string CASE_ID { get; set; }

        [StringLength(32)]
        public string PROVIDER_ID { get; set; }

        [StringLength(32)]
        public string ORIG_PROVIDER { get; set; }

        [StringLength(32)]
        public string NEW_PROVIDER { get; set; }

        [StringLength(32)]
        public string NEW_DIST_ID { get; set; }

        [StringLength(32)]
        public string NEW_SUBDIST_ID { get; set; }

        [StringLength(32)]
        public string NEW_REP_ID { get; set; }

        [Required]
        [StringLength(4)]
        public string NEW_SUBREP_ID { get; set; }

        [StringLength(255)]
        public string NEW_BILLTO_ACCTG_ID { get; set; }

        [StringLength(32)]
        public string NEW_BILLTO_ACCTG_NAME { get; set; }

        [StringLength(64)]
        public string NEW_BILLTO_ADD1 { get; set; }

        [StringLength(64)]
        public string NEW_BILLTO_ADD2 { get; set; }

        [StringLength(64)]
        public string NEW_BILLTO_ADD3 { get; set; }

        [StringLength(64)]
        public string NEW_BILLTO_ADD4 { get; set; }

        [StringLength(64)]
        public string NEW_BILLTO_ADD5 { get; set; }

        [StringLength(255)]
        public string NEW_SHIPTO_ACCTG_ID { get; set; }

        [StringLength(64)]
        public string NEW_SHIPTO_ACCTG_NAME { get; set; }

        [StringLength(64)]
        public string NEW_SHIPTO_ADD1 { get; set; }

        [StringLength(64)]
        public string NEW_SHIPTO_ADD2 { get; set; }

        [StringLength(64)]
        public string NEW_SHIPTO_ADD3 { get; set; }

        [StringLength(64)]
        public string NEW_SHIPTO_ADD4 { get; set; }

        [StringLength(64)]
        public string NEW_SHIPTO_ADD5 { get; set; }
    }
}
