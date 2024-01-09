using Dapper;
using Microsoft.AspNetCore.Mvc;
using StudentsInfo.Constants;
using StudentsInfo.Models;
using System.Data;

namespace StudentsInfo.Controllers
{
    public class GroupsController : Controller
    {
        public IEnumerable<Group> ReadGroups()
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    TableName = "Groups",
                };
                var rows = connection.Query<Group>(
                    DataBaseConstants.ReadRecords,
                     parameters,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool DeleteGroup(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    GroupId = id
                };
                var rows = connection.Execute(
                    DataBaseConstants.GroupDelete,
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return rows > 0;
            }
        }

        public Group ReadGroup(int id)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    GroupId = id
                };
                var group = connection.QueryFirstOrDefault<Group>(
                    DataBaseConstants.GroupRead,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return group;
            }
        }

        public bool CreateGroup(Group group)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    group.Name,
                    group.FacultyId,
                };
                var rows = connection.Execute(
                DataBaseConstants.GroupCreate,
                parameters,
                commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool UpdateGroup(Group group)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    GroupId = group.Id,
                    Name = group.Name,
                    FacultyId = group.FacultyId,
                };
                var rows = connection.Execute(
                    DataBaseConstants.GroupUpdate,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

    }
}
