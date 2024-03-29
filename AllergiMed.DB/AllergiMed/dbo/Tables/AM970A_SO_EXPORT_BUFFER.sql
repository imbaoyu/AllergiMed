﻿CREATE TABLE [dbo].[AM970A_SO_EXPORT_BUFFER] (
    [SEQ_CTR]              INT           IDENTITY (1, 1) NOT NULL,
    [TS]                   ROWVERSION    NULL,
    [FK_AM970_SEQ_CTR]     INT           NULL,
    [FK_AM970A1_SEQ_CTR]   INT           NULL,
    [FK_AM410_SEQ_CTR]     INT           NULL,
    [EXPORT_COMPLETE_FLAG] CHAR (1)      NULL,
    [Customer]             VARCHAR (255) NULL,
    [Transaction Date]     VARCHAR (50)  NULL,
    [RefNumber]            VARCHAR (50)  NULL,
    [PO Number]            VARCHAR (50)  NULL,
    [Terms]                VARCHAR (50)  NULL,
    [Class]                VARCHAR (50)  NULL,
    [Template Name]        VARCHAR (50)  NULL,
    [To Be Printed]        VARCHAR (50)  NULL,
    [Ship Date]            VARCHAR (50)  NULL,
    [Ship Via]             NCHAR (32)    NULL,
    [BillTo Line1]         VARCHAR (50)  NULL,
    [BillTo Line2]         VARCHAR (50)  NULL,
    [BillTo Line3]         VARCHAR (50)  NULL,
    [BillTo Line4]         VARCHAR (50)  NULL,
    [BillTo City]          VARCHAR (50)  NULL,
    [BillTo State]         VARCHAR (50)  NULL,
    [BillTo PostalCode]    VARCHAR (50)  NULL,
    [BillTo Country]       VARCHAR (50)  NULL,
    [ShipTo Line1]         VARCHAR (50)  NULL,
    [ShipTo Line2]         VARCHAR (50)  NULL,
    [ShipTo Line3]         VARCHAR (50)  NULL,
    [ShipTo Line4]         VARCHAR (50)  NULL,
    [ShipTo City]          VARCHAR (50)  NULL,
    [ShipTo State]         VARCHAR (50)  NULL,
    [ShipTo PostalCode]    VARCHAR (50)  NULL,
    [ShipTo Country]       VARCHAR (50)  NULL,
    [Phone]                VARCHAR (50)  NULL,
    [Fax]                  VARCHAR (50)  NULL,
    [Email]                VARCHAR (50)  NULL,
    [Contact Name]         VARCHAR (50)  NULL,
    [First Name]           VARCHAR (50)  NULL,
    [Last Name]            VARCHAR (50)  NULL,
    [Rep]                  VARCHAR (50)  NULL,
    [Due Date]             VARCHAR (50)  NULL,
    [Ship Method]          VARCHAR (50)  NULL,
    [Customer Message]     VARCHAR (50)  NULL,
    [X_MEMO]               VARCHAR (50)  NULL,
    [Item]                 VARCHAR (50)  NULL,
    [Quantity]             VARCHAR (50)  NULL,
    [Description]          VARCHAR (50)  NULL,
    [Price]                VARCHAR (50)  NULL,
    [Is Pending]           VARCHAR (50)  NULL,
    [Item Line Class]      VARCHAR (50)  NULL,
    [Service Date]         VARCHAR (50)  NULL,
    [FOB]                  VARCHAR (50)  NULL,
    [Customer Acct No]     VARCHAR (50)  NULL,
    [Sales Tax Item]       VARCHAR (50)  NULL,
    [To Be E-Mailed]       VARCHAR (50)  NULL,
    [Other]                VARCHAR (50)  NULL,
    [Other1]               VARCHAR (50)  NULL,
    [Other2]               VARCHAR (50)  NULL,
    [Sales Tax Code]       VARCHAR (50)  NULL,
    CONSTRAINT [PK_AM970A_SO_EXPORT_BUFFER] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);

