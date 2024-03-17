using Dapper;
using FoodAPI.DataAccess;
using FoodAPI.InterFace;
using FoodAPI.Models;

namespace FoodAPI.Repository
{
    public class UserBAL: IUser
    {
        private readonly DapperContext _DbContext;
        public UserBAL(DapperContext dbContext)
        {
            _DbContext = dbContext;
        }

       public async Task<IEnumerable<UserRegistrationDetails>> GetUserLoginDetail()
        {
            using(var connectiom = _DbContext.CreateConnection())
            {
                var userList = await connectiom.QueryAsync<UserRegistrationDetails>("Sp_GetUserList", null);
                return userList.ToList();
            }
        }
    }
}
