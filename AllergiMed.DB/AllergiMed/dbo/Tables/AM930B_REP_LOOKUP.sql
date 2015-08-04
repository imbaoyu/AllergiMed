CREATE TABLE [dbo].[AM930B_REP_LOOKUP] (
    [SEQ_CTR]       INT              IDENTITY (1, 1) NOT NULL,
    [ID]            UNIQUEIDENTIFIER NULL,
    [TS]            ROWVERSION       NULL,
    [FK_DIST_ID]    NCHAR (32)       NULL,
    [FK_SUBDIST_ID] NCHAR (32)       CONSTRAINT [DF_AM930B_REP_LOOKUP_FK_SUBDIST_ID] DEFAULT (N'NONE') NULL,
    [REP_ID]        NCHAR (32)       NULL,
    [REP_FULL_ID]   NCHAR (98)       NULL,
    [REP_NAME]      NCHAR (32)       NULL,
    [FIRST_NAME]    NCHAR (16)       NULL,
    [LAST_NAME]     NCHAR (16)       NULL,
    [ADDRESS1]      NCHAR (32)       NULL,
    [ADDRESS2]      NCHAR (32)       NULL,
    [CITY]          NCHAR (24)       NULL,
    [STATE]         NCHAR (10)       NULL,
    [POSTAL]        NCHAR (12)       NULL,
    [PHONE1]        NCHAR (24)       NULL,
    [PHONE2]        NCHAR (24)       NULL,
    [EMAIL1]        NCHAR (64)       NULL,
    [EMAIL2]        NCHAR (64)       NULL,
    CONSTRAINT [PK_AM930B_REP_LOOKUP] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);

