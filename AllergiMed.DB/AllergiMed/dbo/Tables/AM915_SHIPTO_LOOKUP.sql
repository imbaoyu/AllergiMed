CREATE TABLE [dbo].[AM915_SHIPTO_LOOKUP] (
    [SEQ_CTR]            INT              IDENTITY (1, 1) NOT NULL,
    [ID]                 UNIQUEIDENTIFIER NULL,
    [FK_RELATED_BT_ADD1] NCHAR (64)       NULL,
    [ST_ADD1]            NCHAR (64)       NULL,
    [ST_ADD2]            NCHAR (64)       NULL,
    [ST_ADD3]            NCHAR (64)       NULL,
    [ST_ADD4]            NCHAR (64)       NULL,
    [ST_ADD5]            NCHAR (64)       NULL,
    CONSTRAINT [PK_AM915_SHIPTO_LOOKUP] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);

