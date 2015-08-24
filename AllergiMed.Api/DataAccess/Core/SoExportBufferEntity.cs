using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.DataAccess.Core
{
    [Table("AM970A_SO_EXPORT_BUFFER")]
    public class SoExportBufferEntity
    {
        [Key]
        public int SEQ_CTR { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TS { get; set; }

        public int? FK_AM970_SEQ_CTR { get; set; }

        public int? FK_AM970A1_SEQ_CTR { get; set; }

        public int? FK_AM410_SEQ_CTR { get; set; }

        [StringLength(1)]
        public string EXPORT_COMPLETE_FLAG { get; set; }

        [StringLength(255)]
        public string Customer { get; set; }

        [Column("Transaction Date")]
        [StringLength(50)]
        public string Transaction_Date { get; set; }

        [StringLength(50)]
        public string RefNumber { get; set; }

        [Column("PO Number")]
        [StringLength(50)]
        public string PO_Number { get; set; }

        [StringLength(50)]
        public string Terms { get; set; }

        [StringLength(50)]
        public string Class { get; set; }

        [Column("Template Name")]
        [StringLength(50)]
        public string Template_Name { get; set; }

        [Column("To Be Printed")]
        [StringLength(50)]
        public string To_Be_Printed { get; set; }

        [Column("Ship Date")]
        [StringLength(50)]
        public string Ship_Date { get; set; }

        [Column("Ship Via")]
        [StringLength(32)]
        public string Ship_Via { get; set; }

        [Column("BillTo Line1")]
        [StringLength(50)]
        public string BillTo_Line1 { get; set; }

        [Column("BillTo Line2")]
        [StringLength(50)]
        public string BillTo_Line2 { get; set; }

        [Column("BillTo Line3")]
        [StringLength(50)]
        public string BillTo_Line3 { get; set; }

        [Column("BillTo Line4")]
        [StringLength(50)]
        public string BillTo_Line4 { get; set; }

        [Column("BillTo City")]
        [StringLength(50)]
        public string BillTo_City { get; set; }

        [Column("BillTo State")]
        [StringLength(50)]
        public string BillTo_State { get; set; }

        [Column("BillTo PostalCode")]
        [StringLength(50)]
        public string BillTo_PostalCode { get; set; }

        [Column("BillTo Country")]
        [StringLength(50)]
        public string BillTo_Country { get; set; }

        [Column("ShipTo Line1")]
        [StringLength(50)]
        public string ShipTo_Line1 { get; set; }

        [Column("ShipTo Line2")]
        [StringLength(50)]
        public string ShipTo_Line2 { get; set; }

        [Column("ShipTo Line3")]
        [StringLength(50)]
        public string ShipTo_Line3 { get; set; }

        [Column("ShipTo Line4")]
        [StringLength(50)]
        public string ShipTo_Line4 { get; set; }

        [Column("ShipTo City")]
        [StringLength(50)]
        public string ShipTo_City { get; set; }

        [Column("ShipTo State")]
        [StringLength(50)]
        public string ShipTo_State { get; set; }

        [Column("ShipTo PostalCode")]
        [StringLength(50)]
        public string ShipTo_PostalCode { get; set; }

        [Column("ShipTo Country")]
        [StringLength(50)]
        public string ShipTo_Country { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column("Contact Name")]
        [StringLength(50)]
        public string Contact_Name { get; set; }

        [Column("First Name")]
        [StringLength(50)]
        public string First_Name { get; set; }

        [Column("Last Name")]
        [StringLength(50)]
        public string Last_Name { get; set; }

        [StringLength(50)]
        public string Rep { get; set; }

        [Column("Due Date")]
        [StringLength(50)]
        public string Due_Date { get; set; }

        [Column("Ship Method")]
        [StringLength(50)]
        public string Ship_Method { get; set; }

        [Column("Customer Message")]
        [StringLength(50)]
        public string Customer_Message { get; set; }

        [StringLength(50)]
        public string X_MEMO { get; set; }

        [StringLength(50)]
        public string Item { get; set; }

        [StringLength(50)]
        public string Quantity { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Price { get; set; }

        [Column("Is Pending")]
        [StringLength(50)]
        public string Is_Pending { get; set; }

        [Column("Item Line Class")]
        [StringLength(50)]
        public string Item_Line_Class { get; set; }

        [Column("Service Date")]
        [StringLength(50)]
        public string Service_Date { get; set; }

        [StringLength(50)]
        public string FOB { get; set; }

        [Column("Customer Acct No")]
        [StringLength(50)]
        public string Customer_Acct_No { get; set; }

        [Column("Sales Tax Item")]
        [StringLength(50)]
        public string Sales_Tax_Item { get; set; }

        [Column("To Be E-Mailed")]
        [StringLength(50)]
        public string To_Be_E_Mailed { get; set; }

        [StringLength(50)]
        public string Other { get; set; }

        [StringLength(50)]
        public string Other1 { get; set; }

        [StringLength(50)]
        public string Other2 { get; set; }

        [Column("Sales Tax Code")]
        [StringLength(50)]
        public string Sales_Tax_Code { get; set; }
    }
}
