namespace AllergiMed.Api.Models.Case
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AM410_SO_DETAIL
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        public int? FK_AM300_SEQ_CTR { get; set; }

        public int? FK_AM400_SEQ_CTR { get; set; }

        public short? RELEASE_NUMBER { get; set; }

        public decimal? QTY { get; set; }

        [StringLength(64)]
        public string ITEM_ID { get; set; }

        [StringLength(128)]
        public string ITEM_DESC { get; set; }

        [Column(TypeName = "money")]
        public decimal? UNIT_PRICE { get; set; }

        [Column(TypeName = "money")]
        public decimal? EXT_PRICE { get; set; }

        [StringLength(40)]
        public string NOTES { get; set; }

        [StringLength(64)]
        public string LINE_EXPORT_VALIDATION_STATUS { get; set; }
    }
}
