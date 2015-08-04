CREATE TABLE [dbo].[AM920_ITEM_LOOKUP] (
    [SEQ_CTR]                   INT              IDENTITY (1, 1) NOT NULL,
    [ID]                        UNIQUEIDENTIFIER NULL,
    [ITEM_ID]                   NCHAR (64)       NOT NULL,
    [ITEM_DESC]                 NCHAR (64)       NOT NULL,
    [UNIT_PRICE]                MONEY            CONSTRAINT [DF_AM920_ITEM_LOOKUP_UNIT_PRICE] DEFAULT ((0)) NOT NULL,
    [PATIENT_DIRECT_UNIT_PRICE] MONEY            NULL,
    [ITEM_TYPE_ID]              INT              NULL,
    [ITEM_TYPE_DESC]            NCHAR (64)       NULL,
    CONSTRAINT [PK_AM920_ITEM_LOOKUP] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);

