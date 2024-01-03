CREATE PROCEDURE SP_Group_Read
    @GroupId INT
AS
BEGIN
    SELECT * FROM Groups WHERE Id = @GroupId;
END;