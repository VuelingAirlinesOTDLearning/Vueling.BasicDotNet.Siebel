CREATE TABLE [Taskling].[BlockExecution](
	[BlockExecutionId] [bigint] IDENTITY(1,1) NOT NULL,
	[TaskExecutionId] [int] NOT NULL,
	[BlockId] [bigint] NOT NULL,
	[StartedAt] [datetime] NULL,
	[CompletedAt] [datetime] NULL,
	[CreatedAt] [datetime] NOT NULL,
	[Attempt] [int] NOT NULL,
	[ItemsCount] [int] NULL,
	[BlockExecutionStatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_BlockExecution] PRIMARY KEY CLUSTERED 
(
	[BlockExecutionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]