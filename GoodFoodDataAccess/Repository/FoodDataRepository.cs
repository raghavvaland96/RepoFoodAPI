using Dapper;
using GoodFoodDataAccess.DataAccess;
using GoodFoodDataAccess.Interface;
using GoodFoodDataAccess.Models;
using System.Data;

namespace GoodFoodDataAccess.Repository
{
    public class FoodDataRepository : IFoodData
    {
        public readonly sqlDbContext _dbContext;
        public FoodDataRepository(sqlDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string getUserDetails(UserRegistrationDetails loginUserDetails)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@UserId", loginUserDetails.UserId);
                param.Add("@FirstName", loginUserDetails.FirstName);
                param.Add("@LastName", loginUserDetails.LastName);
                param.Add("@UserEmail", loginUserDetails.UserEmail);
                param.Add("@UserPassword", loginUserDetails.UserPassword);

                using (var connection = _dbContext.CreateConnection())
                {
                    var results = connection.Query<int>("sp_InsertUpdateUserDetails", param, commandType: CommandType.StoredProcedure);
                    return results.ToString();
                }
            }
            catch
            {
                throw;
            }
        }
        public async Task<IEnumerable<UserLoginDetails>> getUserLoginDetail()
        {
            DynamicParameters param = new DynamicParameters();
           var objUserDetails = new UserLoginDetails();
            using(var connection = _dbContext.CreateConnection())
            {
                var results = await connection.QueryAsync<UserLoginDetails>("", param);
                return results.ToList();
            }
             
            
        }
    }
}
