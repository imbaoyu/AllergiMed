namespace AllergiMed.Api.Models.Case
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AM970A1_SO_EXPORT_EXPORT_CONTROL_HEADER
    {
        [Key]
        public int SEQ_CTR { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EXPORT_DATE { get; set; }

        [StringLength(32)]
        public string EXPORT_DESC { get; set; }

        [StringLength(1)]
        public string EXPORT_LOCKED_FLAG { get; set; }
    }
}
