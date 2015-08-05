using System.ComponentModel.DataAnnotations;

namespace AllergiMed.Api.Models.Lookup
{
    public partial class AM965_STATE_LOOKUP
    {
        [Key]
        public int SEQ_CTR { get; set; }

        [StringLength(2)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
