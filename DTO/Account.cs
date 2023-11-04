namespace DTO
{
    public class Account
    {
        public int Id { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public string Avatar { get; set; }
        public Account(int id, string username, int role, string avatar)
        {
            Id = id;
            Username = username;
            Role = role;
            Avatar = avatar;
        }
        public Account(string username, string password, int role, string avatar)
        {
            Username = username;
            Password = password;
            Role = role;
            Avatar = avatar;
        }
        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
