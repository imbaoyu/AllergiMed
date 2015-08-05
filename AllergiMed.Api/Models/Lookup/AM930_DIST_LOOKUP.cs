using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Lookup
{
    public partial class AM930_DIST_LOOKUP
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        [StringLength(32)]
        public string DIST_ID { get; set; }

        [StringLength(32)]
        public string DIST_FULL_ID { get; set; }

        [StringLength(50)]
        public string COMPANY_NAME { get; set; }

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

        [StringLength(40)]
        public string ORDER_CONF_TEMPLATE { get; set; }

        [StringLength(6)]
        public string DIST_INITIALS { get; set; }
    }
}
