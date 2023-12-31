CREATE PROCEDURE SP_Group_Update
    @GroupId INT,
    @Name NVARCHAR(50),
    @FacultyId INT
AS
BEGIN
    UPDATE Groups
    SET 
        Name = @Name,
        FacultyId = @FacultyId
    WHERE
        Id = @GroupId;
END;