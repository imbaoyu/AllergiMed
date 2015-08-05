using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Lookup
{
    public partial class AM915A_ROOT_NAME_LOOKUP
    {
        [Key]
        public int SEQ_CTR { get; set; }

        [Required]
        [StringLength(255)]
        public string ROOT_NAME { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TS { get; set; }

        [Required]
        [StringLength(1)]
        public string PATIENT_DIRECT_FLAG { get; set; }
    }
}
