using Dapper;
using Microsoft.AspNetCore.Mvc;
using StudentsInfo.Constants;
using StudentsInfo.Models;
using System.Data;
using System.Xml.Linq;

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

        public bool DeleteFaculty(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    FacultyId = id
                };
                var rows = connection.Execute(
                    DataBaseConstants.FacultyDelete,
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return rows > 0;
            }
        }

        public Faculty ReadFaculty(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    FacultyId = id
                };
                var faculty = connection.QueryFirstOrDefault<Faculty>(
                    DataBaseConstants.FacultyRead,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return faculty;
            }
        }

        public bool UpdateFaculty(Faculty faculty)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    FacultyId = faculty.Id,
                    Name = faculty.Name,
                    Description = faculty.Description,
                };
                var rows = connection.Execute(
                    DataBaseConstants.FacultyUpdate,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }
    }
}
