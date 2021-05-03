using Dapper;
using HollowMindsDev.BackEnd.ApplicationCore.Entities.Users;
using HollowMindsDev.BackEnd.ApplicationCore.Interfaces.IUsers;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HollowMindsDev.BackEnd.Infrastructure.Data.Users
{
    public class AdminRepository : IAdminRepository
    {
        private readonly string _connectionString;

        public AdminRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Database");
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admin> GetAll()
        {
            const string query = @"
SELECT
    mail as EMail
FROM administrator;";
            using var connection = new MySqlConnection(_connectionString);
            return connection.Query<Admin>(query);
        }

        public Admin GetById(int id)
        {
            const string query = @"
SELECT
    mail as EMail
FROM administrator
WHERE idAdmin = @idA;";
            using var connection = new MySqlConnection(_connectionString);
            return connection.QueryFirstOrDefault<Admin>(query);
        }

        public bool IfIsAdmin(string mail)
        {
            throw new NotImplementedException();
        }

        public void Insert(Admin model)
        {
            throw new NotImplementedException();
        }

        public void Update(Admin model)
        {
            throw new NotImplementedException();
        }
    }
}
