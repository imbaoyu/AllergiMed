using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Lookup
{
    public partial class AM940_PHYSICIAN_LOOKUP
    {
        [Key]
        [StringLength(50)]
        public string PHYSICIAN_ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        [StringLength(64)]
        public string PHYSICIAN_NAME { get; set; }
    }
}
