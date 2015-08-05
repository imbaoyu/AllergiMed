using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Lookup
{
    public partial class AM930B_REP_LOOKUP
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        [StringLength(32)]
        public string FK_DIST_ID { get; set; }

        [StringLength(32)]
        public string FK_SUBDIST_ID { get; set; }

        [StringLength(32)]
        public string REP_ID { get; set; }

        [StringLength(98)]
        public string REP_FULL_ID { get; set; }

        [StringLength(32)]
        public string REP_NAME { get; set; }

        [StringLength(16)]
        public string FIRST_NAME { get; set; }

        [StringLength(16)]
        public string LAST_NAME { get; set; }

        [StringLength(32)]
        public string ADDRESS1 { get; set; }

        [StringLength(32)]
        public string ADDRESS2 { get; set; }

        [StringLength(24)]
        public string CITY { get; set; }

        [StringLength(10)]
        public string STATE { get; set; }

        [StringLength(12)]
        public string POSTAL { get; set; }

        [StringLength(24)]
        public string PHONE1 { get; set; }

        [StringLength(24)]
        public string PHONE2 { get; set; }

        [StringLength(64)]
        public string EMAIL1 { get; set; }

        [StringLength(64)]
        public string EMAIL2 { get; set; }
    }
}
