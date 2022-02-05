CREATE TABLE [dbo].[StatisticTypes](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[ShortName] [varchar](10) NOT NULL,
 CONSTRAINT [PK_StatisticTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
)