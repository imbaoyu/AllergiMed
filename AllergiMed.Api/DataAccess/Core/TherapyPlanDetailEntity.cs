using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.DataAccess.Core
{
    [Table("AM950A_THERAPY_PLAN_DETAIL")]
    public class TherapyPlanDetailEntity
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        public int FK_AM950_SEQ_CTR { get; set; }

        public decimal? QTY { get; set; }

        [Required]
        [StringLength(64)]
        public string ITEM_ID { get; set; }

        [StringLength(128)]
        public string ITEM_DESC { get; set; }

        public decimal? UNIT_PRICE { get; set; }

        [Column(TypeName = "money")]
        public decimal? PATIENT_DIRECT_UNIT_PRICE { get; set; }
    }
}
