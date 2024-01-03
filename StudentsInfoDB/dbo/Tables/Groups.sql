CREATE TABLE [dbo].[Groups]
(
	[Id] INT IDENTITY (1, 1) NOT NULL,
	[Name] NVARCHAR(50) NOT NULL, 
    [FacultyId] INT NULL, 
    CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Groups_Faculties] FOREIGN KEY ([FacultyId]) REFERENCES [dbo].[Faculties]([Id]) ON DELETE SET NULL
)
