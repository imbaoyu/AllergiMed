﻿CREATE TABLE [dbo].[AM970B_EXPORT_COMPLETION_STATUS_LOOKUP] (
    [SEQ_CTR]     INT        IDENTITY (1, 1) NOT NULL,
    [TS]          ROWVERSION NULL,
    [STATUS_ID]   NCHAR (3)  NULL,
    [STATUS_DESC] NCHAR (64) NULL,
    CONSTRAINT [PK_AM970B_EXPORT_COMPLETION_STATUS_LOOKUP] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);

