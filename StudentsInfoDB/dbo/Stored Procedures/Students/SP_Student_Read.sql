CREATE PROCEDURE SP_Student_Read
    @StudentId INT
AS
BEGIN
    SELECT * FROM Students WHERE Id = @StudentId;
END;