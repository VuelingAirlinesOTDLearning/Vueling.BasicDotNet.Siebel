﻿CREATE TABLE [Bulk].[Items]
(
	[ItemId] BIGINT NOT NULL IDENTITY(0, 1),
	[BlockId] BIGINT NOT NULL,

    [Name] NVARCHAR(MAX) NOT NULL,
    [Date] DATETIME NOT NULL,

	CONSTRAINT [PK_ItemId] PRIMARY KEY CLUSTERED ([ItemId]),
	CONSTRAINT [FK_Items_Blocks] FOREIGN KEY ([BlockId]) REFERENCES [Bulk].[Blocks]([BlockId]),
)
