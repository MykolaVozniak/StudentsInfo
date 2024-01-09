CREATE PROCEDURE SP_Get_Student_Count_By_Group_Id
    @GroupId INT
AS
BEGIN
    SELECT COUNT(*) AS StudentCount
    FROM Students
    WHERE GroupId = @GroupId;
END;