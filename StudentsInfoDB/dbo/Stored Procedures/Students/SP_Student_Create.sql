CREATE PROCEDURE SP_Student_Create
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @RegistrationDate DATE,
    @AverageScore REAL,
    @GroupId INT
AS
BEGIN
    INSERT INTO Students (FirstName, LastName, RegistrationDate, AverageScore, GroupId)
    VALUES (@FirstName, @LastName, @RegistrationDate, @AverageScore, @GroupId);
END;