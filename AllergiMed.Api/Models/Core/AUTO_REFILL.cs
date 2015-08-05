namespace AllergiMed.Api.Models.Case
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AUTO_REFILL
    {
        public int ID { get; set; }

        public int? PatientID { get; set; }

        [StringLength(100)]
        public string PatientName { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public int? SpecificDay { get; set; }

        public int? IntervalDays { get; set; }

        public DateTime? LastDate { get; set; }

        public int? FormulaID { get; set; }

        public int? DrugID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] LastChanged { get; set; }
    }
}
