CREATE PROCEDURE SP_Department_Create
    @FacultyId INT,
    @Name NVARCHAR(50)
AS
BEGIN
    INSERT INTO Departments (FacultyId, Name)
    VALUES (@FacultyId, @Name);
END;