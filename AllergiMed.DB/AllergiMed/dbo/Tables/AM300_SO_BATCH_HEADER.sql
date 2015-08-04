CREATE TABLE [dbo].[AM300_SO_BATCH_HEADER] (
    [SEQ_CTR]                  INT              IDENTITY (1, 1) NOT NULL,
    [ID]                       UNIQUEIDENTIFIER NULL,
    [TS]                       ROWVERSION       NULL,
    [BATCH_NAME]               NCHAR (64)       NULL,
    [START_PROVIDER_ID]        NCHAR (32)       NULL,
    [END_PROVIDER_ID]          NCHAR (32)       NULL,
    [START_BATCH_MONTH]        NCHAR (3)        NULL,
    [END_BATCH_MONTH]          NCHAR (3)        NULL,
    [START_BATCH_MONTH_NUMBER] INT              NULL,
    [END_BATCH_MONTH_NUMBER]   INT              NULL,
    [BATCH_YEAR]               INT              NULL,
    [BATCH_CLOSED_FLAG]        CHAR (1)         NULL,
    [PURCHASE_ORDER_NUMBER]    CHAR (32)        NULL,
    [SHIP_VIA]                 CHAR (32)        NULL,
    [DELIVERY_DATE]            DATE             NULL,
    [ORDER_NUMBER]             CHAR (20)        NULL,
    [ORDER_DATE]               DATE             NULL,
    [ORDER_CONF_DATE]          DATE             NULL,
    CONSTRAINT [PK_AM300_SO_BATCH_HEADER] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);

