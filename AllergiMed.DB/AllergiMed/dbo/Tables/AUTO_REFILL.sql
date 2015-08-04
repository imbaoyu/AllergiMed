CREATE TABLE [dbo].[AUTO_REFILL] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [PatientID]    INT            NULL,
    [PatientName]  NVARCHAR (100) NULL,
    [Description]  NTEXT          NULL,
    [SpecificDay]  INT            NULL,
    [IntervalDays] INT            NULL,
    [LastDate]     DATETIME       NULL,
    [FormulaID]    INT            NULL,
    [DrugID]       INT            NULL,
    [LastChanged]  ROWVERSION     NOT NULL,
	CONSTRAINT [PK_AUTO_REFILL] PRIMARY KEY CLUSTERED ([ID] ASC)
);

