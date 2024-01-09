CREATE PROCEDURE SP_Get_Faculty_Name
    @FacultyId INT
AS
BEGIN
    SELECT Name
    FROM Faculties
    WHERE Id = @FacultyId;
END;