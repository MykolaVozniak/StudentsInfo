CREATE PROCEDURE SP_Read_Departments_By_FacultyId
    @FacultyId INT
AS
BEGIN
    SELECT Id, Name, FacultyId
    FROM Departments
    WHERE FacultyId = @FacultyId;
END;