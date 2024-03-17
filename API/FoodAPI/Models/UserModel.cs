namespace FoodAPI.Models
{
    public class UserRegistrationDetails
    {
        public string UserId { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;

    }
    public class UserLoginDetails
    {
        public string UserId { get; set; } = string.Empty;
        public string UserPassWord { get; set; } = string.Empty;
    }
}
