namespace StudentsInfo.Constants
{
    public class DataBaseConstants
    {
        #region Dynamic
        public const string ReadRecords = "SP_Read_Records";
        #endregion

        #region Students
        public const string StudentCreate = "SP_Student_Create";
        public const string StudentRead = "SP_Student_Read";
        public const string StudentUpdate = "SP_Student_Update";
        public const string StudentDelete = "SP_Student_Delete";
        #endregion

        #region Groups
        public const string GroupCreate = "SP_Group_Create";
        public const string GroupRead = "SP_Group_Read";
        public const string GroupUpdate = "SP_Group_Update";
        public const string GroupDelete = "SP_Group_Delete";
        #endregion

        #region Departments
        public const string DepartmentCreate = "SP_Department_Create";
        public const string DepartmentRead = "SP_Department_Read";
        public const string DepartmentUpdate = "SP_Department_Update";
        public const string DepartmentDelete = "SP_Department_Delete";
        #endregion

        #region Faculties
        public const string FacultyCreate = "SP_Faculty_Create";
        public const string FacultyRead = "SP_Faculty_Read";
        public const string FacultyUpdate = "SP_Faculty_Update";
        public const string FacultyDelete = "SP_Faculty_Delete";
        #endregion
    }
}
