CREATE PROCEDURE SP_Faculty_Delete
    @FacultyId INT
AS
BEGIN
    UPDATE [dbo].[Groups] SET [FacultyId] = NULL WHERE [FacultyId] = @FacultyId;
    DELETE FROM Faculties WHERE Id = @FacultyId;
END;