CREATE TABLE [dbo].[Fixtures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompetitionId] [smallint] NOT NULL,
	[UtcDate] [datetime2](2) NOT NULL,
	CONSTRAINT [PK_Fixtures] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Fixtures_Competitions] FOREIGN KEY([CompetitionId]) REFERENCES [dbo].[Competitions] ([Id])
)