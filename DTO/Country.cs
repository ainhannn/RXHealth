namespace DTO
{
    public class Country
    {
        public int Id { get; }
        public string Name { get; set; }
        public Country(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Country(string name)
        {
            Name = name;
        }
    }
}
