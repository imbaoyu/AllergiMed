﻿CREATE TABLE [dbo].[AM910_BILLTO_LOOKUP] (
    [SEQ_CTR] INT              IDENTITY (1, 1) NOT NULL,
    [ID]      UNIQUEIDENTIFIER NULL,
    [BT_ADD1] NCHAR (64)       NULL,
    [BT_ADD2] NCHAR (64)       NULL,
    [BT_ADD3] NCHAR (64)       NULL,
    [BT_ADD4] NCHAR (64)       NULL,
    [BT_ADD5] NCHAR (64)       NULL,
    CONSTRAINT [PK_AM910_BILLTO_LOOKUP] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);

