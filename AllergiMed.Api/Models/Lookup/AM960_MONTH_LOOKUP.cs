using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Lookup
{
    public partial class AM960_MONTH_LOOKUP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MONTH_NUMBER { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string MONTH_NAME { get; set; }
    }
}
