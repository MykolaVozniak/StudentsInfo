CREATE PROCEDURE SP_Get_Average_Score_By_Group_Id
    @GroupId INT
AS
BEGIN
    SELECT AVG(AverageScore) AS AverageScore
    FROM Students
    WHERE GroupId = @GroupId AND AverageScore IS NOT NULL;
END;
