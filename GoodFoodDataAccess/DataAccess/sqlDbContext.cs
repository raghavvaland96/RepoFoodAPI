using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace GoodFoodDataAccess.DataAccess
{
    public class sqlDbContext : DbContext
    {
        public sqlDbContext(DbContextOptions<sqlDbContext> options) : base(options)
        {

        }
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public sqlDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("defaultConnectionString");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
