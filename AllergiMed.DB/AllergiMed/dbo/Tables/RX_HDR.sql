﻿CREATE TABLE [dbo].[RX_HDR] (
    [RXInfoID]                   INT            IDENTITY (1, 1) NOT NULL,
    [Number]                     INT            NULL,
    [RefillNumber]               INT            NULL,
    [LogID]                      INT            NULL,
    [Date]                       DATETIME       NULL,
    [Qty]                        FLOAT (53)     NULL,
    [Price]                      FLOAT (53)     NULL,
    [Copay]                      FLOAT (53)     NULL,
    [QtyRemain]                  FLOAT (53)     NULL,
    [DS]                         NVARCHAR (10)  NULL,
    [Patient]                    NVARCHAR (100) NULL,
    [PatientID]                  INT            NULL,
    [Doctor]                     NVARCHAR (100) NULL,
    [MDID]                       INT            NULL,
    [InsID]                      INT            NULL,
    [PatInsID]                   INT            NULL,
    [SIG]                        NTEXT          NULL,
    [Compound]                   BIT            NOT NULL,
    [Drug]                       VARCHAR (100)  NULL,
    [DrugID]                     INT            NULL,
    [Refills]                    FLOAT (53)     NULL,
    [Cost]                       FLOAT (53)     NULL,
    [PriceTableID]               INT            NULL,
    [AWP]                        FLOAT (53)     NULL,
    [PANumber]                   CHAR (15)      NULL,
    [DNDC]                       NVARCHAR (15)  NULL,
    [Voided]                     BIT            NOT NULL,
    [OriginalDate]               DATETIME       NULL,
    [DAWField]                   NVARCHAR (2)   NULL,
    [RPhID]                      INT            NULL,
    [Schedule]                   NVARCHAR (1)   NULL,
    [Notes]                      NTEXT          NULL,
    [SigCodes]                   NTEXT          NULL,
    [OtherDenial]                NVARCHAR (5)   NULL,
    [DURConflict]                NVARCHAR (5)   NULL,
    [DURIntervention]            NVARCHAR (5)   NULL,
    [DUROutcome]                 NVARCHAR (5)   NULL,
    [AuthNumber]                 NVARCHAR (50)  NULL,
    [Paid]                       BIT            NULL,
    [GeneratedRx]                FLOAT (53)     NULL,
    [OnlineResult]               NTEXT          NULL,
    [Diagnosis]                  VARCHAR (165)  NULL,
    [OtherPayor]                 FLOAT (53)     NULL,
    [DenialDate]                 DATETIME       NULL,
    [HCPC]                       NVARCHAR (50)  NULL,
    [Form]                       INT            NULL,
    [Reconciled]                 BIT            NULL,
    [ControlNumber]              NVARCHAR (50)  NULL,
    [Transferred]                BIT            NULL,
    [PAMC]                       VARCHAR (2)    NULL,
    [ARCharge]                   BIT            NULL,
    [MetricQty]                  FLOAT (53)     NULL,
    [DURData]                    VARCHAR (250)  NULL,
    [LevelOfService]             VARCHAR (5)    NULL,
    [Units]                      VARCHAR (50)   NULL,
    [FormulaID]                  INT            NULL,
    [InsData]                    VARCHAR (250)  NULL,
    [OPatInsID]                  INT            NULL,
    [OInsPaid]                   BIT            NULL,
    [OInsAmount]                 FLOAT (53)     NULL,
    [OInsCopay]                  FLOAT (53)     NULL,
    [PInsAmount]                 FLOAT (53)     NULL,
    [PInsCopay]                  FLOAT (53)     NULL,
    [OAuthNumber]                VARCHAR (50)   NULL,
    [OOnlineResult]              NTEXT          NULL,
    [OtherCoverage]              VARCHAR (2)    NULL,
    [OtherType]                  VARCHAR (2)    NULL,
    [PaidQualifier]              VARCHAR (2)    NULL,
    [OtherDate]                  DATETIME       NULL,
    [Deleted]                    BIT            NULL,
    [OnHold]                     BIT            NULL,
    [DateChanged]                DATETIME       NULL,
    [DateUploaded]               DATETIME       NULL,
    [TechID]                     INT            NULL,
    [OtherID]                    VARCHAR (50)   NULL,
    [OtherIDQualifier]           VARCHAR (2)    NULL,
    [RetailPrice]                FLOAT (53)     NULL,
    [OriginalQty]                FLOAT (53)     NULL,
    [OriginalRefills]            INT            NULL,
    [ProductIDQualifier]         VARCHAR (10)   NULL,
    [IncentiveAmount]            FLOAT (53)     NULL,
    [SalesRepID]                 INT            NULL,
    [CouponNumber]               VARCHAR (15)   NULL,
    [CouponType]                 INT            NULL,
    [CouponValue]                FLOAT (53)     NULL,
    [BasisOfCostDetermination]   VARCHAR (2)    NULL,
    [IngredientCostSubmitted]    FLOAT (53)     NULL,
    [DispensingFee]              FLOAT (53)     NULL,
    [ProfessionalServiceFee]     FLOAT (53)     NULL,
    [SalesTaxAmount]             FLOAT (53)     NULL,
    [FlatSalesTaxAmount]         FLOAT (53)     NULL,
    [InjuryID]                   INT            NULL,
    [OtherAmountClaimed]         VARCHAR (150)  NULL,
    [RXServiceNumberQualifier]   VARCHAR (1)    NULL,
    [PartialFillClaimID]         INT            NULL,
    [CustomField1]               VARCHAR (100)  NULL,
    [CustomField2]               VARCHAR (100)  NULL,
    [CustomField3]               VARCHAR (100)  NULL,
    [CustomField4]               VARCHAR (100)  NULL,
    [CustomField5]               VARCHAR (100)  NULL,
    [CustomField6]               VARCHAR (100)  NULL,
    [CustomField7]               VARCHAR (100)  NULL,
    [CustomField8]               VARCHAR (100)  NULL,
    [CustomField9]               VARCHAR (100)  NULL,
    [CustomField10]              VARCHAR (100)  NULL,
    [LastChanged]                ROWVERSION     NOT NULL,
    [RPhIDApproved]              INT            NULL,
    [CurrentClaimID]             INT            NULL,
    [RXID]                       INT            NULL,
    [RX]                         NVARCHAR (50)  NULL,
    [MAC]                        FLOAT (53)     NULL,
    [DAW]                        BIT            NULL,
    [PA]                         BIT            NULL,
    [QBtxnID]                    VARCHAR (100)  NULL,
    [OtherInsCode]               VARCHAR (5)    NULL,
    [EligibilityCode]            VARCHAR (5)    NULL,
    [OriginCode]                 VARCHAR (5)    NULL,
    [RX_GUID]                    VARCHAR (50)   NULL,
    [Clinic]                     NVARCHAR (50)  NULL,
    [Discontinued]               BIT            NULL,
    [Online]                     BIT            NULL,
    [CompoundSufficient]         BIT            NULL,
    [DropOffID]                  NVARCHAR (50)  NULL,
    [DOIDLocal]                  NVARCHAR (50)  NULL,
    [PickupID]                   NVARCHAR (50)  NULL,
    [PULocal]                    NVARCHAR (50)  NULL,
    [DOLocal]                    NVARCHAR (50)  NULL,
    [DORel]                      BIT            NULL,
    [PURel]                      BIT            NULL,
    [PUIDLocal]                  NVARCHAR (50)  NULL,
    [DelayReasonCode]            INT            NULL,
    [TransactionReferenceNumber] VARCHAR (20)   NULL,
    [PatientAssignmentIndicator] BIT            NULL,
    [MedicaidSubrogationsICNTCN] VARCHAR (20)   NULL,
    [PharmacyServiceType]        INT            NULL,
    [DURCoAgentIDQual]           INT            NULL,
    [DURCoAgentID]               VARCHAR (19)   NULL,
    [MedicaidPaidAmount]         MONEY          NULL,
    [CouponValueAmount]          MONEY          NULL,
    [CompoundType]               INT            NULL,
    [RouteofAdministration]      NVARCHAR (13)  NULL,
    [PatientMeasurementID]       INT            NULL,
    [Pets]                       NVARCHAR (50)  NULL,
    [LevelOfEffort]              INT            NULL,
    [DORelationship]             VARCHAR (50)   NULL,
    [PURelationship]             VARCHAR (50)   NULL,
    [DOFirstName]                VARCHAR (50)   NULL,
    [DOLastName]                 VARCHAR (50)   NULL,
    [PUFirstName]                VARCHAR (50)   NULL,
    [PULastName]                 VARCHAR (50)   NULL,
    [OriginalPrice]              FLOAT (53)     NULL,
    [CycleFill]                  BIT            NULL,
    [PrimaryReconcile]           MONEY          NULL,
    [SecondaryReconcile]         MONEY          NULL,
    [PainManagement]             BIT            NULL,
    [OriginallyPrescribedDrugID] INT            NULL,
    [Freq]                       NVARCHAR (5)   NULL,
    [Days]                       NVARCHAR (10)  NULL,
    [StartDate]                  DATETIME       NULL,
    [EndDate]                    DATETIME       NULL,
    [EMarSent]                   BIT            NULL,
    [Profiled]                   BIT            NULL,
    [AccuRoute]                  INT            NULL,
    [Treatment]                  BIT            NULL,
    [abc]                        NCHAR (10)     NULL,
    [def]                        NCHAR (10)     NULL,
	CONSTRAINT [PK_RX_HDR] PRIMARY KEY CLUSTERED ([RXInfoID] ASC)
);
