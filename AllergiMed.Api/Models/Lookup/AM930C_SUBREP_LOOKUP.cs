using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Lookup
{
    public partial class AM930C_SUBREP_LOOKUP
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        [StringLength(32)]
        public string SUBREP_ID { get; set; }

        [StringLength(132)]
        public string SUBREP_FULL_ID { get; set; }

        [StringLength(32)]
        public string FK_DIST_ID { get; set; }

        [StringLength(32)]
        public string FK_REP_ID { get; set; }

        [StringLength(32)]
        public string SUBREP_NAME { get; set; }
    }
}
