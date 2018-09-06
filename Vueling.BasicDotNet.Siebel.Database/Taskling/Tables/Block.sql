CREATE TABLE [Taskling].[Block](
	[BlockId] [bigint] IDENTITY(1,1) NOT NULL,
	[TaskDefinitionId] [int] NOT NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[FromNumber] [bigint] NULL,
	[ToNumber] [bigint] NULL,
	[ObjectData] [nvarchar](max) NULL,
	[CompressedObjectData] [varbinary](MAX) NULL,
	[BlockType] [tinyint] NOT NULL,
	[IsPhantom] [bit] NOT NULL DEFAULT 0,
	[CreatedDate] [datetime] NOT NULL DEFAULT GETUTCDATE(),
 CONSTRAINT [PK_Block] PRIMARY KEY CLUSTERED 
(
	[BlockId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]