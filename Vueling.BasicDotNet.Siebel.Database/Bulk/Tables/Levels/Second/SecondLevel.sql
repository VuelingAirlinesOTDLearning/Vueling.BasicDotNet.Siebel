CREATE TABLE [Bulk].[SecondLevel]
(
	[Id] BIGINT NOT NULL IDENTITY(0, 1),
	[ParentId] BIGINT NOT NULL,

	[SecondMessage] NVARCHAR(MAX) NOT NULL,
	[SecondDate] DATETIME NOT NULL,
	[SecondMoney] DECIMAL(18,5) NULL,

	CONSTRAINT [PK_SecondtLevel_Id] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_SecondtLevel_FirstLevel] FOREIGN KEY ([ParentId]) REFERENCES [Bulk].[FirstLevel]([Id]),
)
