namespace AllergiMed.Api.Models.Case
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RX_HDR
    {
        [Key]
        public int RXInfoID { get; set; }

        public int? Number { get; set; }

        public int? RefillNumber { get; set; }

        public int? LogID { get; set; }

        public DateTime? Date { get; set; }

        public double? Qty { get; set; }

        public double? Price { get; set; }

        public double? Copay { get; set; }

        public double? QtyRemain { get; set; }

        [StringLength(10)]
        public string DS { get; set; }

        [StringLength(100)]
        public string Patient { get; set; }

        public int? PatientID { get; set; }

        [StringLength(100)]
        public string Doctor { get; set; }

        public int? MDID { get; set; }

        public int? InsID { get; set; }

        public int? PatInsID { get; set; }

        [Column(TypeName = "ntext")]
        public string SIG { get; set; }

        public bool Compound { get; set; }

        [StringLength(100)]
        public string Drug { get; set; }

        public int? DrugID { get; set; }

        public double? Refills { get; set; }

        public double? Cost { get; set; }

        public int? PriceTableID { get; set; }

        public double? AWP { get; set; }

        [StringLength(15)]
        public string PANumber { get; set; }

        [StringLength(15)]
        public string DNDC { get; set; }

        public bool Voided { get; set; }

        public DateTime? OriginalDate { get; set; }

        [StringLength(2)]
        public string DAWField { get; set; }

        public int? RPhID { get; set; }

        [StringLength(1)]
        public string Schedule { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Column(TypeName = "ntext")]
        public string SigCodes { get; set; }

        [StringLength(5)]
        public string OtherDenial { get; set; }

        [StringLength(5)]
        public string DURConflict { get; set; }

        [StringLength(5)]
        public string DURIntervention { get; set; }

        [StringLength(5)]
        public string DUROutcome { get; set; }

        [StringLength(50)]
        public string AuthNumber { get; set; }

        public bool? Paid { get; set; }

        public double? GeneratedRx { get; set; }

        [Column(TypeName = "ntext")]
        public string OnlineResult { get; set; }

        [StringLength(165)]
        public string Diagnosis { get; set; }

        public double? OtherPayor { get; set; }

        public DateTime? DenialDate { get; set; }

        [StringLength(50)]
        public string HCPC { get; set; }

        public int? Form { get; set; }

        public bool? Reconciled { get; set; }

        [StringLength(50)]
        public string ControlNumber { get; set; }

        public bool? Transferred { get; set; }

        [StringLength(2)]
        public string PAMC { get; set; }

        public bool? ARCharge { get; set; }

        public double? MetricQty { get; set; }

        [StringLength(250)]
        public string DURData { get; set; }

        [StringLength(5)]
        public string LevelOfService { get; set; }

        [StringLength(50)]
        public string Units { get; set; }

        public int? FormulaID { get; set; }

        [StringLength(250)]
        public string InsData { get; set; }

        public int? OPatInsID { get; set; }

        public bool? OInsPaid { get; set; }

        public double? OInsAmount { get; set; }

        public double? OInsCopay { get; set; }

        public double? PInsAmount { get; set; }

        public double? PInsCopay { get; set; }

        [StringLength(50)]
        public string OAuthNumber { get; set; }

        [Column(TypeName = "ntext")]
        public string OOnlineResult { get; set; }

        [StringLength(2)]
        public string OtherCoverage { get; set; }

        [StringLength(2)]
        public string OtherType { get; set; }

        [StringLength(2)]
        public string PaidQualifier { get; set; }

        public DateTime? OtherDate { get; set; }

        public bool? Deleted { get; set; }

        public bool? OnHold { get; set; }

        public DateTime? DateChanged { get; set; }

        public DateTime? DateUploaded { get; set; }

        public int? TechID { get; set; }

        [StringLength(50)]
        public string OtherID { get; set; }

        [StringLength(2)]
        public string OtherIDQualifier { get; set; }

        public double? RetailPrice { get; set; }

        public double? OriginalQty { get; set; }

        public int? OriginalRefills { get; set; }

        [StringLength(10)]
        public string ProductIDQualifier { get; set; }

        public double? IncentiveAmount { get; set; }

        public int? SalesRepID { get; set; }

        [StringLength(15)]
        public string CouponNumber { get; set; }

        public int? CouponType { get; set; }

        public double? CouponValue { get; set; }

        [StringLength(2)]
        public string BasisOfCostDetermination { get; set; }

        public double? IngredientCostSubmitted { get; set; }

        public double? DispensingFee { get; set; }

        public double? ProfessionalServiceFee { get; set; }

        public double? SalesTaxAmount { get; set; }

        public double? FlatSalesTaxAmount { get; set; }

        public int? InjuryID { get; set; }

        [StringLength(150)]
        public string OtherAmountClaimed { get; set; }

        [StringLength(1)]
        public string RXServiceNumberQualifier { get; set; }

        public int? PartialFillClaimID { get; set; }

        [StringLength(100)]
        public string CustomField1 { get; set; }

        [StringLength(100)]
        public string CustomField2 { get; set; }

        [StringLength(100)]
        public string CustomField3 { get; set; }

        [StringLength(100)]
        public string CustomField4 { get; set; }

        [StringLength(100)]
        public string CustomField5 { get; set; }

        [StringLength(100)]
        public string CustomField6 { get; set; }

        [StringLength(100)]
        public string CustomField7 { get; set; }

        [StringLength(100)]
        public string CustomField8 { get; set; }

        [StringLength(100)]
        public string CustomField9 { get; set; }

        [StringLength(100)]
        public string CustomField10 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] LastChanged { get; set; }

        public int? RPhIDApproved { get; set; }

        public int? CurrentClaimID { get; set; }

        public int? RXID { get; set; }

        [StringLength(50)]
        public string RX { get; set; }

        public double? MAC { get; set; }

        public bool? DAW { get; set; }

        public bool? PA { get; set; }

        [StringLength(100)]
        public string QBtxnID { get; set; }

        [StringLength(5)]
        public string OtherInsCode { get; set; }

        [StringLength(5)]
        public string EligibilityCode { get; set; }

        [StringLength(5)]
        public string OriginCode { get; set; }

        [StringLength(50)]
        public string RX_GUID { get; set; }

        [StringLength(50)]
        public string Clinic { get; set; }

        public bool? Discontinued { get; set; }

        public bool? Online { get; set; }

        public bool? CompoundSufficient { get; set; }

        [StringLength(50)]
        public string DropOffID { get; set; }

        [StringLength(50)]
        public string DOIDLocal { get; set; }

        [StringLength(50)]
        public string PickupID { get; set; }

        [StringLength(50)]
        public string PULocal { get; set; }

        [StringLength(50)]
        public string DOLocal { get; set; }

        public bool? DORel { get; set; }

        public bool? PURel { get; set; }

        [StringLength(50)]
        public string PUIDLocal { get; set; }

        public int? DelayReasonCode { get; set; }

        [StringLength(20)]
        public string TransactionReferenceNumber { get; set; }

        public bool? PatientAssignmentIndicator { get; set; }

        [StringLength(20)]
        public string MedicaidSubrogationsICNTCN { get; set; }

        public int? PharmacyServiceType { get; set; }

        public int? DURCoAgentIDQual { get; set; }

        [StringLength(19)]
        public string DURCoAgentID { get; set; }

        [Column(TypeName = "money")]
        public decimal? MedicaidPaidAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? CouponValueAmount { get; set; }

        public int? CompoundType { get; set; }

        [StringLength(13)]
        public string RouteofAdministration { get; set; }

        public int? PatientMeasurementID { get; set; }

        [StringLength(50)]
        public string Pets { get; set; }

        public int? LevelOfEffort { get; set; }

        [StringLength(50)]
        public string DORelationship { get; set; }

        [StringLength(50)]
        public string PURelationship { get; set; }

        [StringLength(50)]
        public string DOFirstName { get; set; }

        [StringLength(50)]
        public string DOLastName { get; set; }

        [StringLength(50)]
        public string PUFirstName { get; set; }

        [StringLength(50)]
        public string PULastName { get; set; }

        public double? OriginalPrice { get; set; }

        public bool? CycleFill { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrimaryReconcile { get; set; }

        [Column(TypeName = "money")]
        public decimal? SecondaryReconcile { get; set; }

        public bool? PainManagement { get; set; }

        public int? OriginallyPrescribedDrugID { get; set; }

        [StringLength(5)]
        public string Freq { get; set; }

        [StringLength(10)]
        public string Days { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool? EMarSent { get; set; }

        public bool? Profiled { get; set; }

        public int? AccuRoute { get; set; }

        public bool? Treatment { get; set; }

        [StringLength(10)]
        public string abc { get; set; }

        [StringLength(10)]
        public string def { get; set; }
    }
}
