CREATE PROCEDURE SP_Faculty_Create
    @Name NVARCHAR(50),
    @Description NVARCHAR(50),
    @NewFacultyId INT OUTPUT
AS
BEGIN
    INSERT INTO Faculties (Name, Description)
    VALUES (@Name, @Description);

    SET @NewFacultyId = SCOPE_IDENTITY();
END;
