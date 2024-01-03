CREATE PROCEDURE SP_Faculty_Create
    @Name NVARCHAR(50),
    @Description NVARCHAR(50)
AS
BEGIN
    INSERT INTO Faculties (Name, Description)
    VALUES (@Name, @Description);
END;