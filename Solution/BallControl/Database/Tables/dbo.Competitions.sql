CREATE TABLE [dbo].[Competitions](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[LogoUrl] [nvarchar](255) NOT NULL,
	[CountryId] [tinyint] NOT NULL,
	CONSTRAINT [PK_Competitions] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Competitions_Countries] FOREIGN KEY([CountryId]) REFERENCES [dbo].[Countries] ([Id])
)