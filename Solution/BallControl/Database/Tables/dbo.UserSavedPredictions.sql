CREATE TABLE [dbo].[UserSavedPredictions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[PredictionId] [int] NOT NULL,
	CONSTRAINT [PK_UserSavedPredictions] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_UserSavedPredictions_Predictions] FOREIGN KEY([PredictionId]) REFERENCES [dbo].[Predictions] ([Id]),
	CONSTRAINT [FK_UserSavedPredictions_Users] FOREIGN KEY([UserId]) REFERENCES [dbo].[Users] ([Id])
)