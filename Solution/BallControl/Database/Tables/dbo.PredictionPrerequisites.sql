CREATE TABLE [dbo].[PredictionPrerequisites](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PredictionId] [int] NOT NULL,
	[FixtureId] [int] NOT NULL,
	[StatisticTypeId] [tinyint] NOT NULL,
	[Value] [decimal](18, 3) NOT NULL,
	CONSTRAINT [PK_PredictionPrerequisites] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_PredictionPrerequisites_Predictions] FOREIGN KEY([PredictionId]) REFERENCES [dbo].[Predictions] ([Id]),
	CONSTRAINT [FK_PredictionPrerequisites_StatisticTypes] FOREIGN KEY([StatisticTypeId]) REFERENCES [dbo].[StatisticTypes] ([Id])
)