using System.Data.Entity;
using AllergiMed.Api.DataAccess.Core;
using AllergiMed.Api.Models.Core;
using AllergiMed.Api.Models.Lookup;

namespace AllergiMed.Api.DataAccess
{
    public class MedRecordContext : DbContext
    {
        public MedRecordContext()
            : base("name=MedRecordConnection")
        {
        }

        public virtual DbSet<CasesEntity> CasesEntity { get; set; }
        public virtual DbSet<CasesBakEntity> CasesBakEntity { get; set; }
        public virtual DbSet<RxHeaderEntity> RxHeaderEntity { get; set; }
        public virtual DbSet<RxDetailEntity> RxDetailEntity { get; set; }
        public virtual DbSet<RxRenewSchedEntity> RxRenewSchedEntity { get; set; }
        public virtual DbSet<SoBatchHeaderEntity> SoBatchHeaderEntity { get; set; }
        public virtual DbSet<SoHeaderEntity> SoHeaderEntity { get; set; }
        public virtual DbSet<SoDetailEntity> SoDetailEntity { get; set; }
        public virtual DbSet<ExtractFileEntity> ExtractFileEntity { get; set; }
        public virtual DbSet<ItemTypeEntity> ItemTypeEntity { get; set; }
        public virtual DbSet<TherapyPlanHeaderEntity> TherapyPlanHeaderEntity { get; set; }
        public virtual DbSet<TherapyPlanDetailEntity> TherapyPlanDetailEntity { get; set; }
        public virtual DbSet<ExportControlHdrEntity> ExportControlHdrEntity { get; set; }
        public virtual DbSet<SoExportBufferEntity> SoExportBufferEntity { get; set; }
        public virtual DbSet<SoExportControlHeaderEntity> SoExportControlHeaderEntity { get; set; }
        public virtual DbSet<AutoRefillEntity> AutoRefillEntity { get; set; }
        public virtual DbSet<RxHdrEntity> RxHdrEntity { get; set; }
        public virtual DbSet<SimainEntity> SimainEntity { get; set; }

        //lookup tables
        public virtual DbSet<AM900_PROVIDER_LOOKUP> AM900_PROVIDER_LOOKUP { get; set; }
        public virtual DbSet<AM900_PROVIDER_LOOKUP_BUFFER> AM900_PROVIDER_LOOKUP_BUFFER { get; set; }
        public virtual DbSet<AM910_BILLTO_LOOKUP> AM910_BILLTO_LOOKUP { get; set; }
        public virtual DbSet<AM915_SHIPTO_LOOKUP> AM915_SHIPTO_LOOKUP { get; set; }
        public virtual DbSet<AM915A_ROOT_NAME_LOOKUP> AM915A_ROOT_NAME_LOOKUP { get; set; }
        public virtual DbSet<AM920_ITEM_LOOKUP> AM920_ITEM_LOOKUP { get; set; }
        public virtual DbSet<AM930_DIST_LOOKUP> AM930_DIST_LOOKUP { get; set; }
        public virtual DbSet<AM930A_SUBDIST_LOOKUP> AM930A_SUBDIST_LOOKUP { get; set; }
        public virtual DbSet<AM930B_REP_LOOKUP> AM930B_REP_LOOKUP { get; set; }
        public virtual DbSet<AM930C_SUBREP_LOOKUP> AM930C_SUBREP_LOOKUP { get; set; }
        public virtual DbSet<AM940_PHYSICIAN_LOOKUP> AM940_PHYSICIAN_LOOKUP { get; set; }
        public virtual DbSet<AM960_MONTH_LOOKUP> AM960_MONTH_LOOKUP { get; set; }
        public virtual DbSet<AM965_STATE_LOOKUP> AM965_STATE_LOOKUP { get; set; }
        public virtual DbSet<AM970B_EXPORT_COMPLETION_STATUS_LOOKUP> AM970B_EXPORT_COMPLETION_STATUS_LOOKUP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CaseId)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.TestkitLotNumber)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.DistId)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.SubdistId)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.RepId)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.SubrepId)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.ProviderId)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.PatientDirectFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.BilltoAcctgId)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.ShiptoAcctgId)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.ShiptoCity)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.ShiptoState)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.ShiptoPostal)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.ResultsImageFile)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.ConsentOk)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.RxOk)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.ResultsOk)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.FinalOk)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.PatientName)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.PatientAddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.PatientAddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.PatientEmail)
                .IsFixedLength();

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.Spanish)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CcNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CcExpMonth)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CcExpYear)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CcName)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CcAddress)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CcZip)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CcAddressSame)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CustomField1)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CustomField2)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CustomField3)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CustomField4)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CustomField5)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CustomField6)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CustomField7)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CustomField8)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CustomField9)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.CustomField10)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.IdQualifier)
                .IsUnicode(false);

            modelBuilder.Entity<CasesEntity>()
                .Property(e => e.LastRxDate)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CASE_ID)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.TESTKIT_LOT_NUMBER)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.DIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.SUBDIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.REP_ID)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.SUBREP_ID)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.PROVIDER_ID)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.PATIENT_DIRECT_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.BILLTO_ACCTG_ID)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.SHIPTO_ACCTG_ID)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.SHIPTO_CITY)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.SHIPTO_STATE)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.SHIPTO_POSTAL)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.RESULTS_IMAGE_FILE)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CONSENT_OK)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.RX_OK)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.RESULTS_OK)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.FINAL_OK)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.PATIENT_NAME)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.PatientAddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.PatientAddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.PatientEmail)
                .IsFixedLength();

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.Spanish)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CCNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CCExpMonth)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CCExpYear)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CCName)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CCAddress)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CCZip)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CCAddressSame)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CustomField1)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CustomField2)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CustomField3)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CustomField4)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CustomField5)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CustomField6)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CustomField7)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CustomField8)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CustomField9)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.CustomField10)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.IDQualifier)
                .IsUnicode(false);

            modelBuilder.Entity<CasesBakEntity>()
                .Property(e => e.LastRXDate)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.CASE_ID)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.DIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.SUBDIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.REP_ID)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.SUBREP_ID)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.PROVIDER_ID)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.PRACTITIONER_NAME)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.PATIENT_DIRECT_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.BILLTO_ACCTG_ID)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.SHIPTO_ACCTG_ID)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.SHIPTO_CITY)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.SHIPTO_STATE)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.SHIPTO_POSTAL)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.CONSENT_OK)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.RX_OK)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.RESULTS_OK)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.FINAL_OK)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.PATIENT_NAME)
                .IsFixedLength();

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.PatientAddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<RxHeaderEntity>()
                .Property(e => e.PatientAddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<RxDetailEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<RxDetailEntity>()
                .Property(e => e.THERAPY_PLAN_NAME)
                .IsFixedLength();

            modelBuilder.Entity<RxDetailEntity>()
                .Property(e => e.NOTES)
                .IsFixedLength();

            modelBuilder.Entity<RxDetailEntity>()
                .Property(e => e.CHANGE_REASON)
                .IsFixedLength();

            modelBuilder.Entity<RxDetailEntity>()
                .Property(e => e.RELEASE_HOLD_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RxDetailEntity>()
                .Property(e => e.HOLD_REASON)
                .IsFixedLength();

            modelBuilder.Entity<RxDetailEntity>()
                .Property(e => e.TESTKIT_LOT_NUMBER)
                .IsFixedLength();

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.QTY)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.ITEM_ID)
                .IsFixedLength();

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.ITEM_DESC)
                .IsFixedLength();

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.UNIT_PRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.EXT_PRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.SCHED_MONTH)
                .IsFixedLength();

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.PRESELECTED_FOR_RELEASE_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.RELEASED_TO_SALES_ORD_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.NOTES)
                .IsFixedLength();

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.CHANGE_REASON)
                .IsFixedLength();

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.RELEASE_HOLD_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RxRenewSchedEntity>()
                .Property(e => e.HOLD_REASON)
                .IsFixedLength();

            modelBuilder.Entity<SoBatchHeaderEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<SoBatchHeaderEntity>()
                .Property(e => e.BATCH_NAME)
                .IsFixedLength();

            modelBuilder.Entity<SoBatchHeaderEntity>()
                .Property(e => e.START_PROVIDER_ID)
                .IsFixedLength();

            modelBuilder.Entity<SoBatchHeaderEntity>()
                .Property(e => e.END_PROVIDER_ID)
                .IsFixedLength();

            modelBuilder.Entity<SoBatchHeaderEntity>()
                .Property(e => e.START_BATCH_MONTH)
                .IsFixedLength();

            modelBuilder.Entity<SoBatchHeaderEntity>()
                .Property(e => e.END_BATCH_MONTH)
                .IsFixedLength();

            modelBuilder.Entity<SoBatchHeaderEntity>()
                .Property(e => e.BATCH_CLOSED_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SoBatchHeaderEntity>()
                .Property(e => e.PURCHASE_ORDER_NUMBER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SoBatchHeaderEntity>()
                .Property(e => e.SHIP_VIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SoBatchHeaderEntity>()
                .Property(e => e.ORDER_NUMBER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.EXPORTED_TO_ACCTG_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.EXPORT_VALIDATION_STATUS)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.SALES_ORDER_NUMBER)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.PURCHASE_ORDER_NUMBER)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.SALES_ORDER_CLOSED_FLAG)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.SALES_ORDER_COMMENTS)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.PRACTITIONER_NAME)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.EMAIL)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.PATIENT_DIRECT_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.BILLTO_ACCTG_ID)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.SHIPTO_ACCTG_ID)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.SHIPTO_CITY)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.SHIPTO_STATE)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.SHIPTO_POSTAL)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.ORDER_CONF_TEMPLATE)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.SALES_ORDER_TEMPLATE)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.DIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.DIST_INITIALS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.SUBDIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.REP_ID)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.SUBREP_ID)
                .IsFixedLength();

            modelBuilder.Entity<SoHeaderEntity>()
                .Property(e => e.ORDER_NUMBER)
                .IsFixedLength();

            modelBuilder.Entity<SoDetailEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<SoDetailEntity>()
                .Property(e => e.QTY)
                .HasPrecision(6, 2);

            modelBuilder.Entity<SoDetailEntity>()
                .Property(e => e.ITEM_ID)
                .IsFixedLength();

            modelBuilder.Entity<SoDetailEntity>()
                .Property(e => e.ITEM_DESC)
                .IsFixedLength();

            modelBuilder.Entity<SoDetailEntity>()
                .Property(e => e.UNIT_PRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SoDetailEntity>()
                .Property(e => e.EXT_PRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SoDetailEntity>()
                .Property(e => e.NOTES)
                .IsFixedLength();

            modelBuilder.Entity<SoDetailEntity>()
                .Property(e => e.LINE_EXPORT_VALIDATION_STATUS)
                .IsFixedLength();

            modelBuilder.Entity<ExtractFileEntity>()
                .Property(e => e.CASE_ID)
                .IsFixedLength();

            modelBuilder.Entity<ExtractFileEntity>()
                .Property(e => e.PROVIDER_ID)
                .IsFixedLength();

            modelBuilder.Entity<ExtractFileEntity>()
                .Property(e => e.NEW_DIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<ExtractFileEntity>()
                .Property(e => e.NEW_SUBDIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<ExtractFileEntity>()
                .Property(e => e.NEW_REP_ID)
                .IsFixedLength();

            modelBuilder.Entity<ExtractFileEntity>()
                .Property(e => e.NEW_SUBREP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ExtractFileEntity>()
                .Property(e => e.NEW_BILLTO_ACCTG_ID)
                .IsFixedLength();

            modelBuilder.Entity<ExtractFileEntity>()
                .Property(e => e.NEW_SHIPTO_ACCTG_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.DIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.SUBDIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.REP_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.SUBREP_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PHYSICIAN_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PROVIDER_FULL_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PROVIDER0_FNAME)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PROVIDER0_LNAME)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.Provider0StateLic)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.Provider0NPI)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.BILLTO_ACCTG_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.SHIPTO_ACCTG_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PROVIDER1_FNAME)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PROVIDER1_LNAME)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.Provider1StateLic)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.Provider1NPI)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PROVIDER2_FNAME)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PROVIDER2_LNAME)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.Provider2Email)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.Provider2DEA)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.Provider2StateLic)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.Provider2NPI)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PrimaryContactName)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PrimaryContactTitle)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PrimaryContactEmail)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.SpecialInsts)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.OtherStaff1Name)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.OtherStaff1Title)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.OtherStaff1Lic)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.OtherStaff2Name)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.OtherStaff2Title)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.OtherStaff2Lic)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PrescriberLocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.StateIssued)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.TIME_STAMP)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.ORDER_CONF_TEMPLATE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.DIST_ID1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.SUBDIST_ID1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.REP_ID1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.BILLTO_ACCTG_ID1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.SHIPTO_ACCTG_ID1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.PROVIDER_FULL_ID1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP>()
                .Property(e => e.BILLTO_ACCTG_NAME1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.DIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.SUBDIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.REP_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.SUBREP_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PHYSICIAN_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PROVIDER_FULL_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PROVIDER0_FNAME)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PROVIDER0_LNAME)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.Provider0StateLic)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.Provider0NPI)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.BILLTO_ACCTG_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.SHIPTO_ACCTG_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PROVIDER1_FNAME)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PROVIDER1_LNAME)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.Provider1StateLic)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.Provider1NPI)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PROVIDER2_FNAME)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PROVIDER2_LNAME)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.Provider2Email)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.Provider2DEA)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.Provider2StateLic)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.Provider2NPI)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PrimaryContactName)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PrimaryContactTitle)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PrimaryContactEmail)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.SpecialInsts)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.OtherStaff1Name)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.OtherStaff1Title)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.OtherStaff1Lic)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.OtherStaff2Name)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.OtherStaff2Title)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.OtherStaff2Lic)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PrescriberLocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.StateIssued)
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.TIME_STAMP)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.ORDER_CONF_TEMPLATE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.DIST_ID1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.SUBDIST_ID1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.REP_ID1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.BILLTO_ACCTG_ID1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.SHIPTO_ACCTG_ID1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.PROVIDER_FULL_ID1)
                .IsFixedLength();

            modelBuilder.Entity<AM900_PROVIDER_LOOKUP_BUFFER>()
                .Property(e => e.BILLTO_ACCTG_NAME1)
                .IsFixedLength();

            modelBuilder.Entity<AM910_BILLTO_LOOKUP>()
                .Property(e => e.BT_ADD1)
                .IsFixedLength();

            modelBuilder.Entity<AM910_BILLTO_LOOKUP>()
                .Property(e => e.BT_ADD2)
                .IsFixedLength();

            modelBuilder.Entity<AM910_BILLTO_LOOKUP>()
                .Property(e => e.BT_ADD3)
                .IsFixedLength();

            modelBuilder.Entity<AM910_BILLTO_LOOKUP>()
                .Property(e => e.BT_ADD4)
                .IsFixedLength();

            modelBuilder.Entity<AM910_BILLTO_LOOKUP>()
                .Property(e => e.BT_ADD5)
                .IsFixedLength();

            modelBuilder.Entity<AM915_SHIPTO_LOOKUP>()
                .Property(e => e.FK_RELATED_BT_ADD1)
                .IsFixedLength();

            modelBuilder.Entity<AM915_SHIPTO_LOOKUP>()
                .Property(e => e.ST_ADD1)
                .IsFixedLength();

            modelBuilder.Entity<AM915_SHIPTO_LOOKUP>()
                .Property(e => e.ST_ADD2)
                .IsFixedLength();

            modelBuilder.Entity<AM915_SHIPTO_LOOKUP>()
                .Property(e => e.ST_ADD3)
                .IsFixedLength();

            modelBuilder.Entity<AM915_SHIPTO_LOOKUP>()
                .Property(e => e.ST_ADD4)
                .IsFixedLength();

            modelBuilder.Entity<AM915_SHIPTO_LOOKUP>()
                .Property(e => e.ST_ADD5)
                .IsFixedLength();

            modelBuilder.Entity<AM915A_ROOT_NAME_LOOKUP>()
                .Property(e => e.ROOT_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AM915A_ROOT_NAME_LOOKUP>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<AM915A_ROOT_NAME_LOOKUP>()
                .Property(e => e.PATIENT_DIRECT_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AM920_ITEM_LOOKUP>()
                .Property(e => e.ITEM_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM920_ITEM_LOOKUP>()
                .Property(e => e.ITEM_DESC)
                .IsFixedLength();

            modelBuilder.Entity<AM920_ITEM_LOOKUP>()
                .Property(e => e.UNIT_PRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AM920_ITEM_LOOKUP>()
                .Property(e => e.PATIENT_DIRECT_UNIT_PRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AM920_ITEM_LOOKUP>()
                .Property(e => e.ITEM_TYPE_DESC)
                .IsFixedLength();

            modelBuilder.Entity<ItemTypeEntity>()
                .Property(e => e.ITEM_TYPE_DESC)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.DIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.DIST_FULL_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.COMPANY_NAME)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.FIRST_NAME)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.LAST_NAME)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.ADDRESS1)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.ADDRESS2)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.CITY)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.STATE)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.POSTAL)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.PHONE1)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.PHONE2)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.EMAIL1)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.EMAIL2)
                .IsFixedLength();

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.ORDER_CONF_TEMPLATE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AM930_DIST_LOOKUP>()
                .Property(e => e.DIST_INITIALS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.FK_DIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.SUBDIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.SUBDIST_FULL_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.SUBDIST_NAME)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.FIRST_NAME)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.LAST_NAME)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.ADDRESS1)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.ADDRESS2)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.CITY)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.STATE)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.POSTAL)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.PHONE1)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.PHONE2)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.EMAIL1)
                .IsFixedLength();

            modelBuilder.Entity<AM930A_SUBDIST_LOOKUP>()
                .Property(e => e.EMAIL2)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.FK_DIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.FK_SUBDIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.REP_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.REP_FULL_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.REP_NAME)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.FIRST_NAME)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.LAST_NAME)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.ADDRESS1)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.ADDRESS2)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.CITY)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.STATE)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.POSTAL)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.PHONE1)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.PHONE2)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.EMAIL1)
                .IsFixedLength();

            modelBuilder.Entity<AM930B_REP_LOOKUP>()
                .Property(e => e.EMAIL2)
                .IsFixedLength();

            modelBuilder.Entity<AM930C_SUBREP_LOOKUP>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<AM930C_SUBREP_LOOKUP>()
                .Property(e => e.SUBREP_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930C_SUBREP_LOOKUP>()
                .Property(e => e.SUBREP_FULL_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930C_SUBREP_LOOKUP>()
                .Property(e => e.FK_DIST_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930C_SUBREP_LOOKUP>()
                .Property(e => e.FK_REP_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM930C_SUBREP_LOOKUP>()
                .Property(e => e.SUBREP_NAME)
                .IsFixedLength();

            modelBuilder.Entity<AM940_PHYSICIAN_LOOKUP>()
                .Property(e => e.PHYSICIAN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<AM940_PHYSICIAN_LOOKUP>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<AM940_PHYSICIAN_LOOKUP>()
                .Property(e => e.PHYSICIAN_NAME)
                .IsFixedLength();

            modelBuilder.Entity<TherapyPlanHeaderEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<TherapyPlanHeaderEntity>()
                .Property(e => e.THERAPY_PLAN_NAME)
                .IsFixedLength();

            modelBuilder.Entity<TherapyPlanDetailEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<TherapyPlanDetailEntity>()
                .Property(e => e.ITEM_ID)
                .IsFixedLength();

            modelBuilder.Entity<TherapyPlanDetailEntity>()
                .Property(e => e.ITEM_DESC)
                .IsFixedLength();

            modelBuilder.Entity<TherapyPlanDetailEntity>()
                .Property(e => e.PATIENT_DIRECT_UNIT_PRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AM960_MONTH_LOOKUP>()
                .Property(e => e.MONTH_NAME)
                .IsFixedLength();

            modelBuilder.Entity<AM965_STATE_LOOKUP>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AM965_STATE_LOOKUP>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ExportControlHdrEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<ExportControlHdrEntity>()
                .Property(e => e.EXPORT_TYPE)
                .IsFixedLength();

            modelBuilder.Entity<ExportControlHdrEntity>()
                .Property(e => e.EXPORT_DESC)
                .IsFixedLength();

            modelBuilder.Entity<ExportControlHdrEntity>()
                .Property(e => e.EXPORT_VALIDATION_STATUS)
                .IsFixedLength();

            modelBuilder.Entity<ExportControlHdrEntity>()
                .Property(e => e.EXPORT_COMPLETION_STATUS)
                .IsFixedLength();

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.EXPORT_COMPLETE_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Transaction_Date)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.RefNumber)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.PO_Number)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Terms)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Template_Name)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.To_Be_Printed)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Ship_Date)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Ship_Via)
                .IsFixedLength();

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.BillTo_Line1)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.BillTo_Line2)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.BillTo_Line3)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.BillTo_Line4)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.BillTo_City)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.BillTo_State)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.BillTo_PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.BillTo_Country)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.ShipTo_Line1)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.ShipTo_Line2)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.ShipTo_Line3)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.ShipTo_Line4)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.ShipTo_City)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.ShipTo_State)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.ShipTo_PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.ShipTo_Country)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Contact_Name)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Rep)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Due_Date)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Ship_Method)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Customer_Message)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.X_MEMO)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Item)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Quantity)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Price)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Is_Pending)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Item_Line_Class)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Service_Date)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.FOB)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Customer_Acct_No)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Sales_Tax_Item)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.To_Be_E_Mailed)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Other1)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Other2)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportBufferEntity>()
                .Property(e => e.Sales_Tax_Code)
                .IsUnicode(false);

            modelBuilder.Entity<SoExportControlHeaderEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<SoExportControlHeaderEntity>()
                .Property(e => e.EXPORT_DESC)
                .IsFixedLength();

            modelBuilder.Entity<SoExportControlHeaderEntity>()
                .Property(e => e.EXPORT_LOCKED_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AM970B_EXPORT_COMPLETION_STATUS_LOOKUP>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<AM970B_EXPORT_COMPLETION_STATUS_LOOKUP>()
                .Property(e => e.STATUS_ID)
                .IsFixedLength();

            modelBuilder.Entity<AM970B_EXPORT_COMPLETION_STATUS_LOOKUP>()
                .Property(e => e.STATUS_DESC)
                .IsFixedLength();

            modelBuilder.Entity<AutoRefillEntity>()
                .Property(e => e.LastChanged)
                .IsFixedLength();

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.Drug)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.PANumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.Diagnosis)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.PAMC)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.DURData)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.LevelOfService)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.Units)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.InsData)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.OAuthNumber)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.OtherCoverage)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.OtherType)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.PaidQualifier)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.OtherID)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.OtherIDQualifier)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.ProductIDQualifier)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.CouponNumber)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.BasisOfCostDetermination)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.OtherAmountClaimed)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.RXServiceNumberQualifier)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.CustomField1)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.CustomField2)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.CustomField3)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.CustomField4)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.CustomField5)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.CustomField6)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.CustomField7)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.CustomField8)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.CustomField9)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.CustomField10)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.LastChanged)
                .IsFixedLength();

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.QBtxnID)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.OtherInsCode)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.EligibilityCode)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.OriginCode)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.RX_GUID)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.TransactionReferenceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.MedicaidSubrogationsICNTCN)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.DURCoAgentID)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.MedicaidPaidAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.CouponValueAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.DORelationship)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.PURelationship)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.DOFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.DOLastName)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.PUFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.PULastName)
                .IsUnicode(false);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.PrimaryReconcile)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.SecondaryReconcile)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.abc)
                .IsFixedLength();

            modelBuilder.Entity<RxHdrEntity>()
                .Property(e => e.def)
                .IsFixedLength();

            modelBuilder.Entity<SimainEntity>()
                .Property(e => e.TS)
                .IsFixedLength();

            modelBuilder.Entity<SimainEntity>()
                .Property(e => e.PDF_READ_PATH)
                .IsFixedLength();

            modelBuilder.Entity<SimainEntity>()
                .Property(e => e.PDF_TEMP_PATH)
                .IsFixedLength();
        }
    }
}
