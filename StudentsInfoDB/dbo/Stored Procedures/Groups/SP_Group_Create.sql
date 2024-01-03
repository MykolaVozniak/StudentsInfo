CREATE PROCEDURE SP_Group_Create
    @Name NVARCHAR(50),
    @FacultyId INT
AS
BEGIN
    INSERT INTO Groups (Name, FacultyId)
    VALUES (@Name, @FacultyId);
END;