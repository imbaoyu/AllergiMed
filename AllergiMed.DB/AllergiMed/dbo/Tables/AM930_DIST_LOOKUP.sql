CREATE TABLE [dbo].[AM930_DIST_LOOKUP] (
    [SEQ_CTR]             INT              IDENTITY (1, 1) NOT NULL,
    [ID]                  UNIQUEIDENTIFIER NULL,
    [TS]                  ROWVERSION       NULL,
    [DIST_ID]             NCHAR (32)       NULL,
    [DIST_FULL_ID]        NCHAR (32)       NULL,
    [COMPANY_NAME]        NCHAR (50)       NULL,
    [FIRST_NAME]          NCHAR (16)       NULL,
    [LAST_NAME]           NCHAR (16)       NULL,
    [ADDRESS1]            NCHAR (32)       NULL,
    [ADDRESS2]            NCHAR (32)       NULL,
    [CITY]                NCHAR (24)       NULL,
    [STATE]               NCHAR (10)       NULL,
    [POSTAL]              NCHAR (12)       NULL,
    [PHONE1]              NCHAR (24)       NULL,
    [PHONE2]              NCHAR (24)       NULL,
    [EMAIL1]              NCHAR (64)       NULL,
    [EMAIL2]              NCHAR (64)       NULL,
    [ORDER_CONF_TEMPLATE] CHAR (40)        NULL,
    [DIST_INITIALS]       CHAR (6)         NULL,
    CONSTRAINT [PK_AM930_DIST_LOOKUP] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);

