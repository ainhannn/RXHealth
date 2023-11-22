namespace DTO
{
    public class Manufacturer
    {
        public int Id { get; }
        public string Name { get; set; }
        public Manufacturer(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Manufacturer(string name)
        {
            Name = name;
        }
    }
}
