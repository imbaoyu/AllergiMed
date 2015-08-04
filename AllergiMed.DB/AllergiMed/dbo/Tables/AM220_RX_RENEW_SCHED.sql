CREATE TABLE [dbo].[AM220_RX_RENEW_SCHED] (
    [SEQ_CTR]                      INT              IDENTITY (1, 1) NOT NULL,
    [FK_AM210_SEQ_CTR]             INT              NOT NULL,
    [ID]                           UNIQUEIDENTIFIER NULL,
    [TS]                           ROWVERSION       NULL,
    [RELEASE_NUMBER]               SMALLINT         NULL,
    [QTY]                          DECIMAL (6, 2)   CONSTRAINT [DF_AM220_RX_RENEW_SCHED_QTY] DEFAULT ((1)) NULL,
    [ITEM_ID]                      NCHAR (64)       NULL,
    [ITEM_DESC]                    NCHAR (128)      NULL,
    [UNIT_PRICE]                   MONEY            CONSTRAINT [DF_AM220_RX_RENEW_SCHED_UNIT_PRICE] DEFAULT ((0)) NULL,
    [EXT_PRICE]                    MONEY            CONSTRAINT [DF_AM220_RX_RENEW_SCHED_EXT_PRICE] DEFAULT ((0)) NULL,
    [DELIVERY_LEAD_DAYS]           SMALLINT         CONSTRAINT [DF_AM220_RX_RENEW_SCHED_DELIVERY_LEAD_DAYS] DEFAULT ((2)) NULL,
    [PRODUCTION_LEAD_DAYS]         SMALLINT         CONSTRAINT [DF_AM220_RX_RENEW_SCHED_PRODUCTION_LEAD_DAYS] DEFAULT ((16)) NULL,
    [GROSS_CYCLE_DAYS]             SMALLINT         CONSTRAINT [DF_AM220_RX_RENEW_SCHED_GROSS_CYCLE_DAYS] DEFAULT ((0)) NULL,
    [NET_CYCLE_DAYS]               SMALLINT         CONSTRAINT [DF_AM220_RX_RENEW_SCHED_NET_CYCLE_DAYS] DEFAULT ((0)) NULL,
    [SCHED_MONTH]                  NCHAR (3)        NULL,
    [SCHED_MONTH_NUMBER]           INT              NULL,
    [SCHED_DATE]                   DATE             NULL,
    [LATE__DATE]                   DATE             NULL,
    [RELEASE_SO_DATE]              DATE             NULL,
    [DELIVERY_DATE]                DATE             NULL,
    [ACTUAL_RELEASE_DATE]          DATE             NULL,
    [PRESELECTED_FOR_RELEASE_FLAG] CHAR (1)         CONSTRAINT [DF_AM220_RX_RENEW_SCHED_PRESELECTED_FOR_RELEASE_FLAG] DEFAULT ('N') NULL,
    [FK_AM300_SEQ_CTR]             INT              CONSTRAINT [DF_AM220_RX_RENEW_SCHED_FK_AM300_SEQ_CTR] DEFAULT ((0)) NULL,
    [SCHED_YEAR]                   INT              NULL,
    [RELEASED_TO_SALES_ORD_FLAG]   CHAR (1)         CONSTRAINT [DF_AM220_RX_RENEW_SCHED_RELEASED_TO_SALES_ORD_FLAG] DEFAULT ('N') NULL,
    [NOTES]                        NCHAR (40)       NULL,
    [CHANGE_REASON]                NCHAR (64)       NULL,
    [RELEASE_HOLD_FLAG]            CHAR (1)         NULL,
    [HOLD_REASON]                  NCHAR (64)       NULL,
    [LAST_CHANGE_DATE]             DATE             NULL,
    [HOLD_DATE]                    DATE             NULL,
    CONSTRAINT [PK_AM220_RX_RENEW_SCHED] PRIMARY KEY CLUSTERED ([SEQ_CTR] ASC)
);


GO
CREATE NONCLUSTERED INDEX [NonClusteredIndex-AM220_COMPOUND_INDEX]
    ON [dbo].[AM220_RX_RENEW_SCHED]([FK_AM210_SEQ_CTR] ASC)
    INCLUDE([RELEASE_NUMBER], [SCHED_MONTH_NUMBER], [PRESELECTED_FOR_RELEASE_FLAG], [FK_AM300_SEQ_CTR], [SCHED_YEAR], [RELEASED_TO_SALES_ORD_FLAG]);

