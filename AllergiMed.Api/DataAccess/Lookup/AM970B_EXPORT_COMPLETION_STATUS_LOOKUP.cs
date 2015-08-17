using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Lookup
{
    //AM970B_EXPORT_COMPLETION_STATUS_LOOKUP
    public partial class AM970B_EXPORT_COMPLETION_STATUS_LOOKUP
    {
        [Key]
        public int SEQ_CTR { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        [StringLength(3)]
        public string STATUS_ID { get; set; }

        [StringLength(64)]
        public string STATUS_DESC { get; set; }
    }
}
