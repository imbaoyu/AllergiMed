﻿CREATE TABLE [dbo].[AM970A1_SO_EXPORT_EXPORT_CONTROL_HEADER] (
    [SEQ_CTR]            INT        IDENTITY (1, 1) NOT NULL,
    [TS]                 ROWVERSION NOT NULL,
    [EXPORT_DATE]        DATE       NULL,
    [EXPORT_DESC]        NCHAR (32) NULL,
    [EXPORT_LOCKED_FLAG] CHAR (1)   NULL,
    CONSTRAINT [PK_AM970A1_SO_EXPORT_EXPORT_CONTROL_HEADER] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);
