CREATE TABLE [Bulk].[ThirdLevelB]
(
	[Id] BIGINT NOT NULL IDENTITY(0, 1),
	[ParentId] BIGINT NOT NULL,

	[ThirdMessage] NVARCHAR(MAX) NOT NULL,
	[ThirdDate] DATETIME NOT NULL,
	[ThirdMoney] DECIMAL(18,5) NULL,

	CONSTRAINT [PK_ThirdLevelB_Id] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_ThirdLevelB_SecondLevel] FOREIGN KEY ([ParentId]) REFERENCES [Bulk].[SecondLevel]([Id]),
)
