namespace DTO
{
    public class Account
    {
        public int Id { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public Account(int id, string username, int role)
        {
            Id = id;
            Username = username;
            Role = role;
        }
        public Account(string username, string password, int role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
