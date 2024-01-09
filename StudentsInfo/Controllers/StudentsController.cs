using Dapper;
using Microsoft.AspNetCore.Mvc;
using StudentsInfo.Constants;
using StudentsInfo.Models;
using System.Data;

namespace StudentsInfo.Controllers
{
    public class StudentsController : Controller
    {
        public IEnumerable<Student> ReadStudents()
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    TableName = "Students",
                };
                var rows = connection.Query<Student>(
                    DataBaseConstants.ReadRecords,
                     parameters,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool DeleteStudent(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    StudentId = id
                };
                var rows = connection.Execute(
                    DataBaseConstants.StudentDelete,
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return rows > 0;
            }
        }

        public Student ReadStudent(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    StudentId = id
                };
                var student = connection.QueryFirstOrDefault<Student>(
                    DataBaseConstants.StudentRead,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return student;
            }
        }

        public bool CreateStudent(Student student)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    RegistrationDate = student.RegistrationDate,
                    AverageScore = student.AverageScore,
                    GroupId = student.GroupId,
                };
                var rows = connection.Execute(
                DataBaseConstants.StudentCreate,
                parameters,
                commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool UpdateStudent(Student student)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    StudentId = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    RegistrationDate = student.RegistrationDate,
                    AverageScore = student.AverageScore,
                    GroupId = student.GroupId,
    };
                var rows = connection.Execute(
                    DataBaseConstants.StudentUpdate,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }
    }
}
