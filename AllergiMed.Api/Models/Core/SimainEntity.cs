using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Core
{
    //SIMAIN
    [Table("SIMAIN")]
    public partial class SimainEntity
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        [StringLength(64)]
        public string PDF_READ_PATH { get; set; }

        [StringLength(64)]
        public string PDF_TEMP_PATH { get; set; }
    }
}
