CREATE PROCEDURE SP_Group_Delete
    @GroupId INT
AS
BEGIN
    UPDATE [dbo].[Students] SET [GroupId] = NULL WHERE [GroupId] = @GroupId;
    DELETE FROM Groups WHERE Id = @GroupId;
END;