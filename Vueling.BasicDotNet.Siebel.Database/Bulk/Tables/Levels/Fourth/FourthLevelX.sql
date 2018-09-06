CREATE TABLE [Bulk].[FourthLevelX]
(
	[Id] BIGINT NOT NULL IDENTITY(0, 1),

	[FourthMessage] NVARCHAR(MAX) NOT NULL,
	[FourthDate] DATETIME NOT NULL,
	[FourthMoney] DECIMAL(18,5) NULL,

	CONSTRAINT [PK_FourthLevelX_Id] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_FourthLevelX_ThirdLevelB] FOREIGN KEY ([Id]) REFERENCES [Bulk].[ThirdLevelB]([Id]),
)
