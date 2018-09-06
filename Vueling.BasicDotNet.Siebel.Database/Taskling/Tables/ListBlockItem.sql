CREATE TABLE [Taskling].[ListBlockItem](
	[ListBlockItemId] [bigint] IDENTITY(1,1) NOT NULL,
	[BlockId] [bigint] NOT NULL,
	[Value] [nvarchar](max) NULL,
	[CompressedValue] [varbinary](MAX) NULL,
	[Status] [tinyint] NOT NULL,
    [Timestamp] DATETIME NULL, 
	[LastUpdated] DATETIME NULL, 
	[StatusReason] nvarchar(max) NULL,
	[Step] tinyint NULL,
    CONSTRAINT [PK_ListBlockItem] PRIMARY KEY CLUSTERED 
(
	[BlockId] ASC,
	[ListBlockItemId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]