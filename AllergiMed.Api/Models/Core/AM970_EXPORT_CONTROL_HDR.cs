namespace AllergiMed.Api.Models.Case
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AM970_EXPORT_CONTROL_HDR
    {
        [Key]
        public int SEQ_CTR { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TS { get; set; }

        public int? FK_AM300_SEQ_CTR { get; set; }

        public int? FK_AM400_SEQ_CTR { get; set; }

        public int? FK_AM970A1_SEQ_CTR { get; set; }

        [StringLength(5)]
        public string EXPORT_TYPE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EXPORT_DATE { get; set; }

        [StringLength(255)]
        public string EXPORT_DESC { get; set; }

        [StringLength(64)]
        public string EXPORT_VALIDATION_STATUS { get; set; }

        [StringLength(64)]
        public string EXPORT_COMPLETION_STATUS { get; set; }
    }
}
