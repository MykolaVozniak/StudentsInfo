CREATE PROCEDURE SP_Delete_Departments_By_FacultyId
    @FacultyId INT
AS
BEGIN
    DELETE FROM Departments WHERE FacultyId = @FacultyId;
END;