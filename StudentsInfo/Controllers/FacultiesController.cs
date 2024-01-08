using Dapper;
using Microsoft.AspNetCore.Mvc;
using StudentsInfo.Constants;
using StudentsInfo.Models;
using System.Data;

namespace StudentsInfo.Controllers
{
    public class FacultiesController : Controller
    {
        public IEnumerable<Faculty> ReadFaculties()
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    TableName = "Faculties",
                };
                var rows = connection.Query<Faculty>(
                    DataBaseConstants.ReadRecords,
                     parameters,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public int CreateFaculty(Faculty faculty)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("@Name", faculty.Name);
                parameters.Add("@Description", faculty.Description);
                parameters.Add("@NewFacultyId", dbType: DbType.Int32, direction: ParameterDirection.Output);
                var rows = connection.Execute(
                DataBaseConstants.FacultyCreate,
                parameters,
                commandType: CommandType.StoredProcedure);
                if (rows > 0)
                {
                    return parameters.Get<int>("@NewFacultyId");
                }
                return 0;
            }
        }
    }
}
