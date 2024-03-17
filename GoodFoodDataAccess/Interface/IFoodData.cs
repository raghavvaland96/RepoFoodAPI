using GoodFoodDataAccess.Models;

namespace GoodFoodDataAccess.Interface
{
    public interface IFoodData
    {
        public string getUserDetails(UserRegistrationDetails loginUserDetails);

        public Task<IEnumerable<UserLoginDetails>> getUserLoginDetail();
    }
}
