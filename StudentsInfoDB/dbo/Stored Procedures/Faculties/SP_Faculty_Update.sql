CREATE PROCEDURE SP_Faculty_Update
    @FacultyId INT,
    @Name NVARCHAR(50),
    @Description NVARCHAR(50)
AS
BEGIN
    UPDATE Faculties
    SET 
        Name = @Name,
        Description = @Description
    WHERE
        Id = @FacultyId;
END;