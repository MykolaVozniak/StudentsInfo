CREATE PROCEDURE SP_Faculty_Read
    @FacultyId INT
AS
BEGIN
    SELECT * FROM Faculties WHERE Id = @FacultyId;
END;