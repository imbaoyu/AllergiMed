using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.DataAccess.Core
{
    [Table("AUTO_REFILL")]
    public class AutoRefillEntity
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("PatientID")]
        public int? PatientId { get; set; }

        [StringLength(100)]
        [Column("PatientName")]
        public string PatientName { get; set; }

        [Column("Description", TypeName = "ntext")]
        public string Description { get; set; }

        [Column("SpecificDay")]
        public int? SpecificDay { get; set; }

        [Column("IntervalDays")]
        public int? IntervalDays { get; set; }

        [Column("LastDate")]
        public DateTime? LastDate { get; set; }

        [Column("FormulaID")]
        public int? FormulaId { get; set; }

        [Column("DrugID")]
        public int? DrugId { get; set; }

        [Column("LastChanged", TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] LastChanged { get; set; }
    }
}
