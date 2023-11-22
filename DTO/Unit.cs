namespace DTO
{
    public class Unit
    {
        public int Id { get; }
        public string Name { get; set; }
        public Unit Subunit { get; set; }
        public int Number { get; set; }
        public Unit(int id, string name, Unit subunit, int number)
        {
            Id = id;
            Name = name;
            Subunit = subunit;
            Number = number;
        }
        public Unit(string name, Unit subunit, int number)
        {
            Name = name;
            Subunit = subunit;
            Number = number;
        }
        public Unit(string name)
        {
            Name = name;
            Subunit = null;
            Number = 0;
        }
    }
}
