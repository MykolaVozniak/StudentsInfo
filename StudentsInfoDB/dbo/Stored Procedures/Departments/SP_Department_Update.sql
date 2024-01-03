CREATE PROCEDURE SP_Department_Update
    @DepartmentId INT,
    @Name NVARCHAR(50),
    @FacultyId INT
AS
BEGIN
    UPDATE Departments
    SET 
        Name = @Name,
        FacultyId = @FacultyId
    WHERE
        Id = @DepartmentId;
END;