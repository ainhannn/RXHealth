namespace DTO
{
    public class Provider
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public double Debt { get; set; }
        public DateTimeCycle TimeCycle { get; set; }
        public Provider(int id) { Id = id; }
        public Provider(int id, string name, string phone, string address, double debt, DateTimeCycle timeCycle)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Address = address;
            Debt = debt;
            TimeCycle = timeCycle;
        }
        public Provider(string name, string phone, string address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }
    }
}
