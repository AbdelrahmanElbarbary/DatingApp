namespace DatingApp.API2._2.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}