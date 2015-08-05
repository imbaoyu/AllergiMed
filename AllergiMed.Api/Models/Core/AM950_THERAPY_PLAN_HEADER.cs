namespace AllergiMed.Api.Models.Case
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AM950_THERAPY_PLAN_HEADER
    {
        [Key]
        public int SEQ_CTR { get; set; }

        public Guid? ID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        [StringLength(40)]
        public string THERAPY_PLAN_NAME { get; set; }

        public short? RELEASES_PER_YEAR { get; set; }

        public short? DELIVERY_LEAD_DAYS { get; set; }

        public short? PRODUCTION_LEAD_DAYS { get; set; }

        public short? GROSS_CYCLE_DAYS { get; set; }

        public short? NET_CYCLE_DAYS { get; set; }
    }
}
