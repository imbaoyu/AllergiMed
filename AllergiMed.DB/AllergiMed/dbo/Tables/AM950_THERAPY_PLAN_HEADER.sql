﻿CREATE TABLE [dbo].[AM950_THERAPY_PLAN_HEADER] (
    [SEQ_CTR]              INT              IDENTITY (1, 1) NOT NULL,
    [ID]                   UNIQUEIDENTIFIER NULL,
    [TS]                   ROWVERSION       NULL,
    [THERAPY_PLAN_NAME]    NCHAR (40)       CONSTRAINT [DF_AM950_THERAPY_PLAN_HEADER_THERAPY_PLAN_NAME] DEFAULT ((4)) NULL,
    [RELEASES_PER_YEAR]    SMALLINT         NULL,
    [DELIVERY_LEAD_DAYS]   SMALLINT         CONSTRAINT [DF_AM950_THERAPY_PLAN_HEADER_DELIVERY_LEAD_DAYS] DEFAULT ((2)) NULL,
    [PRODUCTION_LEAD_DAYS] SMALLINT         CONSTRAINT [DF_AM950_THERAPY_PLAN_HEADER_PRODUCTION_LEAD_DAYS] DEFAULT ((16)) NULL,
    [GROSS_CYCLE_DAYS]     SMALLINT         CONSTRAINT [DF_AM950_THERAPY_PLAN_HEADER_GROSS_CYCLE_DAYS] DEFAULT ((0)) NULL,
    [NET_CYCLE_DAYS]       SMALLINT         CONSTRAINT [DF_AM950_THERAPY_PLAN_HEADER_NET_CYCLE_DAYS] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_AM950_THERAPY_PLAN_HEADER] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);

