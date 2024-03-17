using FoodAPI.InterFace;
using FoodAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodAPI.Controllers
{
    [ApiController]
    public class UserControllercs : Controller
    {
        private readonly IUser _IUser;

        public UserControllercs(IUser user)
        {
            _IUser = user;
        }


        [HttpGet]
        [Route("API/GetUserDetails")]
        public async Task<List<UserRegistrationDetails>> GetUserDetails()
        {
            List<UserRegistrationDetails> UserRegistrationDetails = new List<UserRegistrationDetails>();
            try
            {
                UserRegistrationDetails = (List<UserRegistrationDetails>)await _IUser.GetUserLoginDetail();
                return UserRegistrationDetails;
            }
            catch (Exception ex)
            {
                return new List<UserRegistrationDetails>();
            }
        }
    }
}
