using Dapper;
using Microsoft.AspNetCore.Mvc;
using StudentsInfo.Constants;
using StudentsInfo.Models;
using System.Data;

namespace StudentsInfo.Controllers
{
    public class DepartmentsController : Controller
    {
        public IEnumerable<Department> ReadDepartmentsById(int facultyId)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    FacultyId = facultyId
                };

                var departments = connection.Query<Department>(
                    DataBaseConstants.ReadDepartmentsByFacultyId,
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return departments;
            }
        }

        public bool CreateDepartment(Department department)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    department.Name,
                    department.FacultyId,
                };
                var rows = connection.Execute(
                DataBaseConstants.DepartmentCreate,
                parameters,
                commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }
    }
}
