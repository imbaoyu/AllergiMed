using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.DataAccess.Core
{
    [Table("AM300_SO_BATCH_HEADER")]
    public class SoBatchHeaderEntity
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        [StringLength(64)]
        public string BATCH_NAME { get; set; }

        [StringLength(32)]
        public string START_PROVIDER_ID { get; set; }

        [StringLength(32)]
        public string END_PROVIDER_ID { get; set; }

        [StringLength(3)]
        public string START_BATCH_MONTH { get; set; }

        [StringLength(3)]
        public string END_BATCH_MONTH { get; set; }

        public int? START_BATCH_MONTH_NUMBER { get; set; }

        public int? END_BATCH_MONTH_NUMBER { get; set; }

        public int? BATCH_YEAR { get; set; }

        [StringLength(1)]
        public string BATCH_CLOSED_FLAG { get; set; }

        [StringLength(32)]
        public string PURCHASE_ORDER_NUMBER { get; set; }

        [StringLength(32)]
        public string SHIP_VIA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DELIVERY_DATE { get; set; }

        [StringLength(20)]
        public string ORDER_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ORDER_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ORDER_CONF_DATE { get; set; }
    }
}
