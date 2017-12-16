CREATE TABLE [dbo].[MemoryAction] (
    [ID]        INT  NOT NULL,
    [ID_wallet] INT  NOT NULL,
    [ID_action] INT  NOT NULL,
    [Money]     INT  NOT NULL,
    [DateUse]   DATE NOT NULL,
    CONSTRAINT [PK_MemoryAction] PRIMARY KEY CLUSTERED ([ID] ASC)
);

