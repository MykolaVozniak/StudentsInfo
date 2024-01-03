CREATE PROCEDURE SP_Student_Delete
    @StudentId INT
AS
BEGIN
    DELETE FROM Students WHERE Id = @StudentId;
END;