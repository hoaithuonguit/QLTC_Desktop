CREATE TABLE [dbo].[Wallet] (
    [ID]         INT            NOT NULL,
    [Name]       NVARCHAR (MAX) NOT NULL,
    [FirstMoney] INT            NOT NULL,
    [Money]      INT            NOT NULL,
    CONSTRAINT [PK_Wallet] PRIMARY KEY CLUSTERED ([ID] ASC)
);

