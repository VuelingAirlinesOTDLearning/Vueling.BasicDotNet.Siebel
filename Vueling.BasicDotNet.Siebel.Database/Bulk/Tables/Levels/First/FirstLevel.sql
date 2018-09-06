﻿CREATE TABLE [Bulk].[FirstLevel]
(
	[Id] BIGINT NOT NULL IDENTITY(0, 1),

	[FirstMessage] NVARCHAR(MAX) NOT NULL,
	[FirstDate] DATETIME NOT NULL,
	[FirstMoney] DECIMAL(18,5) NULL,

	CONSTRAINT [PK_FirstLevel_Id] PRIMARY KEY CLUSTERED ([Id]),
)