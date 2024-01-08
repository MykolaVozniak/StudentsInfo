CREATE PROCEDURE sp_Read_Records
    @TableName NVARCHAR(255)
AS
BEGIN
    DECLARE @SqlQuery NVARCHAR(MAX);

    SET @SqlQuery = N'SELECT * FROM ' + QUOTENAME(@TableName);

    EXEC sp_executesql @SqlQuery;
END;