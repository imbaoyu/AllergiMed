CREATE TABLE [dbo].[AM200_RX_HEADER] (
    [SEQ_CTR]             INT              IDENTITY (1, 1) NOT NULL,
    [FK_AM100_SEQ_CTR]    INT              NULL,
    [CASE_ID]             NCHAR (64)       NULL,
    [ID]                  UNIQUEIDENTIFIER NULL,
    [TS]                  ROWVERSION       NULL,
    [INTAKE_DATE]         DATE             CONSTRAINT [DF_AM200_RX_HEADER_INTAKE_DATE] DEFAULT (getdate()) NULL,
    [EDIT_DATE]           DATE             NULL,
    [LAST_TEST_DATE]      DATE             NULL,
    [NEXT_TEST_DATE]      DATE             NULL,
    [FIRST_VISIT_DATE]    DATE             NULL,
    [SECOND_VISIT_DATE]   DATE             NULL,
    [THIRD_VISIT_DATE]    DATE             NULL,
    [FOURTH_VISIT_DATE]   DATE             NULL,
    [RETEST_DATE]         DATE             NULL,
    [DIST_ID]             NCHAR (32)       NULL,
    [SUBDIST_ID]          NCHAR (32)       CONSTRAINT [DF_AM200_RX_HEADER_SUBDIST_ID] DEFAULT (N'NONE') NULL,
    [REP_ID]              NCHAR (32)       NULL,
    [SUBREP_ID]           NCHAR (32)       CONSTRAINT [DF_AM200_RX_HEADER_SUBREP_ID] DEFAULT (N'NONE') NULL,
    [PROVIDER_ID]         NCHAR (32)       NULL,
    [PRACTITIONER_NAME]   NCHAR (42)       NULL,
    [PATIENT_DIRECT_FLAG] CHAR (1)         NULL,
    [BILLTO_ACCTG_ID]     NCHAR (255)      NULL,
    [BILLTO_ACCTG_NAME]   NVARCHAR (64)    NULL,
    [BILLTO_ADD1]         NVARCHAR (64)    NULL,
    [BILLTO_ADD2]         NVARCHAR (64)    NULL,
    [BILLTO_ADD3]         NVARCHAR (64)    NULL,
    [BILLTO_ADD4]         NVARCHAR (64)    NULL,
    [BILLTO_ADD5]         NVARCHAR (64)    NULL,
    [SHIPTO_ACCTG_ID]     NCHAR (255)      NULL,
    [SHIPTO_ACCTG_NAME]   NVARCHAR (64)    NULL,
    [SHIPTO_ADD1]         NVARCHAR (64)    NULL,
    [SHIPTO_ADD2]         NVARCHAR (64)    NULL,
    [SHIPTO_ADD3]         NVARCHAR (64)    NULL,
    [SHIPTO_ADD4]         NVARCHAR (64)    NULL,
    [SHIPTO_ADD5]         NVARCHAR (64)    NULL,
    [SHIPTO_CITY]         NCHAR (32)       NULL,
    [SHIPTO_STATE]        NCHAR (8)        NULL,
    [SHIPTO_POSTAL]       NCHAR (12)       NULL,
    [CONSENT_OK]          NCHAR (1)        CONSTRAINT [DF_AM200_RX_HEADER_CONSENT_OK] DEFAULT (N'N') NULL,
    [RX_OK]               NCHAR (1)        CONSTRAINT [DF_AM200_RX_HEADER_RX_OK] DEFAULT (N'N') NULL,
    [RESULTS_OK]          NCHAR (1)        CONSTRAINT [DF_AM200_RX_HEADER_RESULTS_OK] DEFAULT (N'N') NULL,
    [FINAL_OK]            NCHAR (1)        NULL,
    [PATIENT_NAME]        NCHAR (70)       NULL,
    [PatientAddressLine1] VARCHAR (50)     NULL,
    [PatientAddressLine2] VARCHAR (50)     NULL,
    [PatientCity]         NVARCHAR (25)    NULL,
    [PatientState]        NVARCHAR (10)    NULL,
    [PatientZipCode]      NVARCHAR (12)    NULL,
    CONSTRAINT [PK_AM200_RX_HEADER] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);


GO
CREATE NONCLUSTERED INDEX [NonClusteredIndex-AM200-PROVIDER_ID]
    ON [dbo].[AM200_RX_HEADER]([PROVIDER_ID] ASC);


GO
CREATE NONCLUSTERED INDEX [NonClusteredIndex-AM200-PATIENT-NAME-REL-NO]
    ON [dbo].[AM200_RX_HEADER]([PATIENT_NAME] ASC);

