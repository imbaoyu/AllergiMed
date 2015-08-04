CREATE TABLE [dbo].[AM410_SO_DETAIL] (
    [SEQ_CTR]                       INT              IDENTITY (1, 1) NOT NULL,
    [ID]                            UNIQUEIDENTIFIER NULL,
    [TS]                            ROWVERSION       NULL,
    [FK_AM300_SEQ_CTR]              INT              NULL,
    [FK_AM400_SEQ_CTR]              INT              NULL,
    [RELEASE_NUMBER]                SMALLINT         NULL,
    [QTY]                           DECIMAL (6, 2)   NULL,
    [ITEM_ID]                       NCHAR (64)       NULL,
    [ITEM_DESC]                     NCHAR (128)      NULL,
    [UNIT_PRICE]                    MONEY            NULL,
    [EXT_PRICE]                     MONEY            NULL,
    [NOTES]                         NCHAR (40)       NULL,
    [LINE_EXPORT_VALIDATION_STATUS] NCHAR (64)       NULL,
    CONSTRAINT [PK_AM410_SO_DETAIL] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);

