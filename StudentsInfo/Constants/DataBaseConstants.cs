using System.Data.SqlClient;
namespace StudentsInfo.Constants
{
    public class DataBaseConstants
    {

        private const string ConnectionString = "Data Source=DESKTOP-UNRBAFF\\SQLEXPRESS;Initial Catalog=StudentsInfoDB;Persist Security Info=True;User ID=sa;Password=mykola228";
        public static SqlConnection GetConnection()
            => new(ConnectionString);

        #region Dynamic
        public const string ReadRecords = "SP_Read_Records"; //used
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

        public const string ReadDepartmentsByFacultyId = "SP_Read_Departments_By_FacultyId"; //used
        public const string DeleteDepartmentsByFacultyId = "SP_Delete_Departments_By_FacultyId";
        #endregion

        #region Faculties
        public const string FacultyCreate = "SP_Faculty_Create"; //used
        public const string FacultyRead = "SP_Faculty_Read";
        public const string FacultyUpdate = "SP_Faculty_Update";
        public const string FacultyDelete = "SP_Faculty_Delete";

        public const string GetFacultyName = "SP_Get_Faculty_Name";
        #endregion
    }
}
