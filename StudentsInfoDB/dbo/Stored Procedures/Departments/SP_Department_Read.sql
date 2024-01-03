CREATE PROCEDURE SP_Department_Read
    @DepartmentId INT
AS
BEGIN
    SELECT * FROM Departments WHERE Id = @DepartmentId;
END;