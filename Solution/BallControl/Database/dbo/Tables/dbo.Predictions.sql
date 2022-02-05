CREATE TABLE [dbo].[Predictions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FixtureId] [int] NOT NULL,
	[DisplayText] [nvarchar](500) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[StatusId] [tinyint] NOT NULL,
	CONSTRAINT [PK_Predictions] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Predictions_Fixtures] FOREIGN KEY([FixtureId]) REFERENCES [dbo].[Fixtures] ([Id]),
	CONSTRAINT [FK_Predictions_PredictionStatuses] FOREIGN KEY([StatusId]) REFERENCES [dbo].[PredictionStatuses] ([Id])
)