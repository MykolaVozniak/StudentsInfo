CREATE PROCEDURE SP_Department_Delete
    @DepartmentId INT
AS
BEGIN
    DELETE FROM Departments WHERE Id = @DepartmentId;
END;