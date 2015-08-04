﻿CREATE TABLE [dbo].[AM940_PHYSICIAN_LOOKUP] (
    [PHYSICIAN_ID]   VARCHAR (50) NOT NULL,
    [TS]             ROWVERSION   NULL,
    [PHYSICIAN_NAME] NCHAR (64)   NULL,
    CONSTRAINT [PK_AM940_PHYSICIAN_LOOKUP] PRIMARY KEY CLUSTERED ([PHYSICIAN_ID] ASC)
);

