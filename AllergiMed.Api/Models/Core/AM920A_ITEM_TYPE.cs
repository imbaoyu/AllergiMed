namespace AllergiMed.Api.Models.Case
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AM920A_ITEM_TYPE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ITEM_TYPE_ID { get; set; }

        [StringLength(64)]
        public string ITEM_TYPE_DESC { get; set; }
    }
}
