﻿CREATE TABLE [Bulk].[Blocks]
(
	[BlockId] BIGINT NOT NULL IDENTITY(0, 1),
	 
    [Created] DATETIME NOT NULL,
    [Completed] DATETIME NOT NULL,

	CONSTRAINT [PK_BlockId] PRIMARY KEY CLUSTERED ([BlockId]),
)
