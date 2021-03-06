﻿CREATE TABLE [Bulk].[FourthLevelB]
(
	[Id] BIGINT NOT NULL IDENTITY(0, 1),
	[ParentId] BIGINT NOT NULL,

	[FourthMessage] NVARCHAR(MAX) NOT NULL,
	[FourthDate] DATETIME NOT NULL,
	[FourthMoney] DECIMAL(18,5) NULL,

	CONSTRAINT [PK_FourthLevelB_Id] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_FourthLevelB_ThirdLevelA] FOREIGN KEY ([ParentId]) REFERENCES [Bulk].[ThirdLevelA]([Id]),
)
