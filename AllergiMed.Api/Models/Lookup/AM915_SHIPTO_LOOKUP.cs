using System;
using System.ComponentModel.DataAnnotations;

namespace AllergiMed.Api.Models.Lookup
{
    public partial class AM915_SHIPTO_LOOKUP
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [StringLength(64)]
        public string FK_RELATED_BT_ADD1 { get; set; }

        [StringLength(64)]
        public string ST_ADD1 { get; set; }

        [StringLength(64)]
        public string ST_ADD2 { get; set; }

        [StringLength(64)]
        public string ST_ADD3 { get; set; }

        [StringLength(64)]
        public string ST_ADD4 { get; set; }

        [StringLength(64)]
        public string ST_ADD5 { get; set; }
    }
}
