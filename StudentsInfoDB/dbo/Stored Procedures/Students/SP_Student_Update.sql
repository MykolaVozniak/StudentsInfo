CREATE PROCEDURE SP_Student_Update
    @StudentId INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @RegistrationDate DATE,
    @AverageScore REAL,
    @GroupId INT
AS
BEGIN
    UPDATE Students
    SET 
        FirstName = @FirstName,
        LastName = @LastName,
        RegistrationDate = @RegistrationDate,
        AverageScore = @AverageScore,
        GroupId = @GroupId
    WHERE
        Id = @StudentId;
END;