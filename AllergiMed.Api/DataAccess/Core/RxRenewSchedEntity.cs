using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Core
{
    [Table("AM220_RX_RENEW_SCHED")]
    public class RxRenewSchedEntity
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public int FK_AM210_SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

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

        public short? DELIVERY_LEAD_DAYS { get; set; }

        public short? PRODUCTION_LEAD_DAYS { get; set; }

        public short? GROSS_CYCLE_DAYS { get; set; }

        public short? NET_CYCLE_DAYS { get; set; }

        [StringLength(3)]
        public string SCHED_MONTH { get; set; }

        public int? SCHED_MONTH_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SCHED_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LATE__DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RELEASE_SO_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DELIVERY_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ACTUAL_RELEASE_DATE { get; set; }

        [StringLength(1)]
        public string PRESELECTED_FOR_RELEASE_FLAG { get; set; }

        public int? FK_AM300_SEQ_CTR { get; set; }

        public int? SCHED_YEAR { get; set; }

        [StringLength(1)]
        public string RELEASED_TO_SALES_ORD_FLAG { get; set; }

        [StringLength(40)]
        public string NOTES { get; set; }

        [StringLength(64)]
        public string CHANGE_REASON { get; set; }

        [StringLength(1)]
        public string RELEASE_HOLD_FLAG { get; set; }

        [StringLength(64)]
        public string HOLD_REASON { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_CHANGE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HOLD_DATE { get; set; }
    }
}
