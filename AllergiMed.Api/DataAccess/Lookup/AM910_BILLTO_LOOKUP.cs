using System;
using System.ComponentModel.DataAnnotations;

namespace AllergiMed.Api.Models.Lookup
{
    public partial class AM910_BILLTO_LOOKUP
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [StringLength(64)]
        public string BT_ADD1 { get; set; }

        [StringLength(64)]
        public string BT_ADD2 { get; set; }

        [StringLength(64)]
        public string BT_ADD3 { get; set; }

        [StringLength(64)]
        public string BT_ADD4 { get; set; }

        [StringLength(64)]
        public string BT_ADD5 { get; set; }
    }
}
