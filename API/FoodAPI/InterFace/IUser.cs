using FoodAPI.Models;

namespace FoodAPI.InterFace
{
    public interface IUser
    {
        public Task<IEnumerable<UserRegistrationDetails>> GetUserLoginDetail();
    }
}
