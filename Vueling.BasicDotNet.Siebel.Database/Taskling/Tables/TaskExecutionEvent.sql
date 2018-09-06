CREATE TABLE [Taskling].[TaskExecutionEvent](
	[TaskExecutionEventId] [bigint] IDENTITY(1,1) NOT NULL,
	[TaskExecutionId] [int] NOT NULL,
	[EventType] [tinyint] NOT NULL,
	[Message] [nvarchar](MAX) NULL,
	[EventDateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_TaskExecutionEvent] PRIMARY KEY CLUSTERED 
(
	[TaskExecutionEventId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]