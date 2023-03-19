namespace CookieLogin.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public class AdminInit
    {
        public static List<Admin> Init()
        {
            return new List<Admin>
            {
                new Admin(){Id = 1, Username = "Ali", Password = "123456", Role = "Admin"},
                new Admin(){Id = 2, Username = "Can", Password = "123456", Role = "Author"},
                new Admin(){Id = 3, Username = "Veli", Password = "123456", Role = "Author"}
            };
        }
    }
}
