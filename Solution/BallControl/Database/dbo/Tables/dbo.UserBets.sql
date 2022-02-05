CREATE TABLE [dbo].[UserBets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[PredictionId] [int] NOT NULL,
	[Multiplier] [decimal](18, 5) NOT NULL,
	[Amount] [decimal](18, 5) NOT NULL,
	[CreatedDateUtc] [datetime2](2) NOT NULL,
	CONSTRAINT [PK_UserBets] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_UserBets_Predictions] FOREIGN KEY([PredictionId]) REFERENCES [dbo].[Predictions] ([Id]),
	CONSTRAINT [FK_UserBets_Users] FOREIGN KEY([UserId]) REFERENCES [dbo].[Users] ([Id])
)
