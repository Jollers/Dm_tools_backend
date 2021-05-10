
namespace Dm_tools_backend.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int id, string email, string password)
        {
            Id = id;
            Email = email;
            Password = password;
        }
    }
}
