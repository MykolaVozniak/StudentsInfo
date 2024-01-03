CREATE TABLE [dbo].[Departments]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL,
    [FacultyId] INT NOT NULL, 
    CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY ([FacultyId]) REFERENCES [dbo].[Faculties]([Id]) ON DELETE CASCADE
)
