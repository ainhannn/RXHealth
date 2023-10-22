namespace DTO
{
    public class Customer
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Point { get; set; } = 0;
        public Customer(int id, string name, string phone, int point)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Point = point;
        }
        public Customer(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}
