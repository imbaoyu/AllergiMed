CREATE TABLE [dbo].[test_table] (
    [seq_ctr] BIGINT     IDENTITY (1, 1) NOT NULL,
    [data]    NCHAR (10) NULL,
    CONSTRAINT [PK_test_table] PRIMARY KEY CLUSTERED ([seq_ctr] ASC)
);

