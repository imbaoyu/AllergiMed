using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergiMed.Api.Models.Lookup
{
    public partial class AM900_PROVIDER_LOOKUP_BUFFER
    {
        public int SEQ_CTR { get; set; }

        [Key]
        public int SEQ_CTR_1 { get; set; }

        public Guid? ID { get; set; }

        [StringLength(32)]
        public string DIST_ID { get; set; }

        [StringLength(32)]
        public string SUBDIST_ID { get; set; }

        [StringLength(32)]
        public string REP_ID { get; set; }

        [StringLength(32)]
        public string SUBREP_ID { get; set; }

        [StringLength(32)]
        public string PHYSICIAN_ID { get; set; }

        [StringLength(32)]
        public string PROVIDER_ID { get; set; }

        [StringLength(198)]
        public string PROVIDER_FULL_ID { get; set; }

        [StringLength(30)]
        public string PracticeName { get; set; }

        [StringLength(20)]
        public string PROVIDER0_FNAME { get; set; }

        [StringLength(20)]
        public string PROVIDER0_LNAME { get; set; }

        [StringLength(42)]
        public string Provider0Name { get; set; }

        [StringLength(50)]
        public string Provider0Email { get; set; }

        [StringLength(14)]
        public string Provider0DEA { get; set; }

        [StringLength(20)]
        public string Provider0StateLic { get; set; }

        [StringLength(20)]
        public string Provider0NPI { get; set; }

        [StringLength(255)]
        public string BILLTO_ACCTG_ID { get; set; }

        [StringLength(32)]
        public string BILLTO_ACCTG_NAME { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD1 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD2 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD3 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD4 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD5 { get; set; }

        [StringLength(255)]
        public string SHIPTO_ACCTG_ID { get; set; }

        [StringLength(64)]
        public string SHIPTO_ACCTG_NAME { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD1 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD2 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD3 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD4 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD5 { get; set; }

        [StringLength(15)]
        public string Telephone1 { get; set; }

        [StringLength(15)]
        public string Telephone2 { get; set; }

        [StringLength(15)]
        public string FaxNumber { get; set; }

        [Column(TypeName = "ntext")]
        public string Comments { get; set; }

        [StringLength(20)]
        public string PROVIDER1_FNAME { get; set; }

        [StringLength(20)]
        public string PROVIDER1_LNAME { get; set; }

        [StringLength(42)]
        public string Provider1Name { get; set; }

        [StringLength(50)]
        public string Provider1Email { get; set; }

        [StringLength(14)]
        public string Provider1DEA { get; set; }

        [StringLength(20)]
        public string Provider1StateLic { get; set; }

        [StringLength(20)]
        public string Provider1NPI { get; set; }

        [StringLength(20)]
        public string PROVIDER2_FNAME { get; set; }

        [StringLength(20)]
        public string PROVIDER2_LNAME { get; set; }

        [StringLength(42)]
        public string Provider2Name { get; set; }

        [StringLength(50)]
        public string Provider2Email { get; set; }

        [StringLength(20)]
        public string Provider2DEA { get; set; }

        [StringLength(20)]
        public string Provider2StateLic { get; set; }

        [StringLength(20)]
        public string Provider2NPI { get; set; }

        [StringLength(30)]
        public string PrimaryContactName { get; set; }

        [StringLength(64)]
        public string PrimaryContactTitle { get; set; }

        [StringLength(64)]
        public string PrimaryContactEmail { get; set; }

        [StringLength(128)]
        public string SpecialInsts { get; set; }

        [StringLength(64)]
        public string OtherStaff1Name { get; set; }

        [StringLength(64)]
        public string OtherStaff1Title { get; set; }

        [StringLength(20)]
        public string OtherStaff1Lic { get; set; }

        [StringLength(64)]
        public string OtherStaff2Name { get; set; }

        [StringLength(64)]
        public string OtherStaff2Title { get; set; }

        [StringLength(20)]
        public string OtherStaff2Lic { get; set; }

        [StringLength(3)]
        public string PrescriberLocationCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastRXDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastTestKitDate { get; set; }

        public double? NumberofScripts { get; set; }

        public int? ImportID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public DateTime? DateEntered { get; set; }

        public DateTime? DateChanged { get; set; }

        public DateTime? DateUploaded { get; set; }

        [StringLength(15)]
        public string StateIssued { get; set; }

        [StringLength(50)]
        public string SPI { get; set; }

        public double? PriceAmount { get; set; }

        [Column(TypeName = "image")]
        public byte[] DoctorImage { get; set; }

        public bool? FaxRequests { get; set; }

        [StringLength(4)]
        public string DoctorCode { get; set; }

        public int? PrimaryID { get; set; }

        [StringLength(120)]
        public string PrimaryName { get; set; }

        public bool? Deleted { get; set; }

        public int? SalesRep { get; set; }

        [StringLength(30)]
        public string ShippingAddressLine1 { get; set; }

        [StringLength(30)]
        public string ShippingAddressLine2 { get; set; }

        [StringLength(20)]
        public string ShippingCity { get; set; }

        [StringLength(2)]
        public string ShippingState { get; set; }

        [StringLength(15)]
        public string ShippingZip { get; set; }

        [StringLength(25)]
        public string ShippingCountry { get; set; }

        [StringLength(25)]
        public string Country { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TIME_STAMP { get; set; }

        [StringLength(40)]
        public string ORDER_CONF_TEMPLATE { get; set; }

        [StringLength(32)]
        public string DIST_ID1 { get; set; }

        [StringLength(32)]
        public string SUBDIST_ID1 { get; set; }

        [StringLength(32)]
        public string REP_ID1 { get; set; }

        [StringLength(255)]
        public string BILLTO_ACCTG_ID1 { get; set; }

        [StringLength(255)]
        public string SHIPTO_ACCTG_ID1 { get; set; }

        [StringLength(32)]
        public string PROVIDER_ID1 { get; set; }

        [StringLength(198)]
        public string PROVIDER_FULL_ID1 { get; set; }

        [StringLength(64)]
        public string BILLTO_ACCTG_NAME1 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD11 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD21 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD31 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD41 { get; set; }

        [StringLength(64)]
        public string BILLTO_ADD51 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ACCTG_NAME1 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD11 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD21 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD31 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD41 { get; set; }

        [StringLength(64)]
        public string SHIPTO_ADD51 { get; set; }
    }
}
