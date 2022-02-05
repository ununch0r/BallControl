CREATE TABLE [dbo].[PredictionStatuses](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	CONSTRAINT [PK_PredictionStatuses] PRIMARY KEY CLUSTERED ([Id] ASC)
)