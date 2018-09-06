CREATE TABLE [Taskling].[ForceBlockQueue](
	[ForceBlockQueueId] [int] IDENTITY(1,1) NOT NULL,
	[BlockId] [bigint] NOT NULL,
	[ForcedDate] [datetime] NOT NULL,
	[ForcedBy] [varchar](50) NOT NULL,
	[ProcessingStatus] [varchar](20) NOT NULL,
 CONSTRAINT [PK_ForceBlockQueue] PRIMARY KEY CLUSTERED 
(
	[ForceBlockQueueId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


ALTER TABLE [Taskling].[ForceBlockQueue] ADD  DEFAULT (getutcdate()) FOR [ForcedDate]
GO

ALTER TABLE [Taskling].[ForceBlockQueue] ADD  DEFAULT ('Pending') FOR [ProcessingStatus]
GO