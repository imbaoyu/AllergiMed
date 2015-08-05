using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Lookup
{
    public partial class AM920_ITEM_LOOKUP
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [Required]
        [StringLength(64)]
        public string ITEM_ID { get; set; }

        [Required]
        [StringLength(64)]
        public string ITEM_DESC { get; set; }

        [Column(TypeName = "money")]
        public decimal UNIT_PRICE { get; set; }

        [Column(TypeName = "money")]
        public decimal? PATIENT_DIRECT_UNIT_PRICE { get; set; }

        public int? ITEM_TYPE_ID { get; set; }

        [StringLength(64)]
        public string ITEM_TYPE_DESC { get; set; }
    }
}
