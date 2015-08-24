using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.DataAccess.Core
{
    [Table("AM210_RX_DETAIL")]
    public class RxDetailEntity
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public int FK_AM200_SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        [StringLength(40)]
        public string THERAPY_PLAN_NAME { get; set; }

        public short? RELEASES_PER_YEAR { get; set; }

        public short? DELIVERY_LEAD_DAYS { get; set; }

        public short? PRODUCTION_LEAD_DAYS { get; set; }

        public short? GROSS_CYCLE_DAYS { get; set; }

        public short? NET_CYCLE_DAYS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? START_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? END_DATE { get; set; }

        public int? TOTAL_RELEASES { get; set; }

        public int? RELEASED_TO_SALES_ORD { get; set; }

        public int? REMAINING_RELEASES { get; set; }

        [StringLength(40)]
        public string NOTES { get; set; }

        [StringLength(64)]
        public string CHANGE_REASON { get; set; }

        [StringLength(1)]
        public string RELEASE_HOLD_FLAG { get; set; }

        [StringLength(64)]
        public string HOLD_REASON { get; set; }

        [StringLength(20)]
        public string TESTKIT_LOT_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TESTKIT_LOT_DATE { get; set; }
    }
}
