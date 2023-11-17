namespace DTO
{
    public class Substance
    {
        public int Id { get; }
        public string Name { get; set; }
        public Substance(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Substance(string name)
        {
            Name = name;
        }
    }
}
