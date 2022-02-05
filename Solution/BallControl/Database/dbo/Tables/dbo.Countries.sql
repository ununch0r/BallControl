CREATE TABLE [dbo].[Countries]
(
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FlagUrl] [nvarchar](255) NOT NULL,
	CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED ([Id] ASC)
)