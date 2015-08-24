using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.DataAccess.Core
{
    [Table("AM920A_ITEM_TYPE")]
    public class ItemTypeEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ITEM_TYPE_ID { get; set; }

        [StringLength(64)]
        public string ITEM_TYPE_DESC { get; set; }
    }
}
