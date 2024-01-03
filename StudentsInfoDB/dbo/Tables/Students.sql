CREATE TABLE [dbo].[Students]
(
	[Id] INT IDENTITY (1, 1) NOT NULL,
	[FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [RegistrationDate] DATE NOT NULL, 
    [AverageScore] REAL NULL, 
    [GroupId] INT NULL, 
    CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Students_Groups] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups]([Id]) ON DELETE SET NULL
)
