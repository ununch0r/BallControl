SET IDENTITY_INSERT [dbo].[Countries] ON

MERGE INTO [dbo].[Countries] AS Target USING (VALUES
(1,'England','GB','https://media.api-sports.io/flags/gb.svg'),
(2,'Spain','ES','https://media.api-sports.io/flags/es.svg'),
(3,'Italy','IT','https://media.api-sports.io/flags/it.svg'),
(4,'Germany','DE','https://media.api-sports.io/flags/de.svg'),
(5,'France','FR','https://media.api-sports.io/flags/fr.svg'),
(6,'Ukraine','UA','https://media.api-sports.io/flags/ua.svg')
) AS Source ([Id],[Code],[Name],[FlagUrl]) ON Target.[Id]=Source.[Id]
WHEN MATCHED AND (Source.[Name] <> Target.[Name] COLLATE Latin1_General_CS_AS)
			 OR	 (Source.[Code] <> Target.[Code] COLLATE Latin1_General_CS_AS)
			 OR	 (Source.[FlagUrl] <> Target.[FlagUrl] COLLATE Latin1_General_CS_AS) THEN
UPDATE SET [Name]=Source.[Name], [Code]=Source.[Code], [FlagUrl]=Source.[FlagUrl]
WHEN NOT MATCHED BY TARGET THEN
INSERT ([Id],[Code],[Name],[FlagUrl])
VALUES ([Id],[Code],[Name],[FlagUrl]);

SET IDENTITY_INSERT [dbo].[Countries] OFF