CREATE TABLE [dbo].[Faculties]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NULL,
    CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED ([Id] ASC)
)
