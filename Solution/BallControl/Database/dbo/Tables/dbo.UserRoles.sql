CREATE TABLE [dbo].[UserRoles](
	[RoleId] [tinyint] NOT NULL,
	[UserId] [int] NOT NULL,
	CONSTRAINT [PK_UserRoles_1] PRIMARY KEY CLUSTERED 
	(
		[RoleId] ASC,
		[UserId] ASC
	),
	CONSTRAINT [FK_UserRoles_Roles] FOREIGN KEY([RoleId]) REFERENCES [dbo].[Roles] ([Id]),
	CONSTRAINT [FK_UserRoles_Users] FOREIGN KEY([UserId]) REFERENCES [dbo].[Users] ([Id])
)