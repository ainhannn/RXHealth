namespace DTO
{
    public class Ingredient
    {
        public int Id { get; }
        public string Name { get; set; }
        public Ingredient(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Ingredient(string name)
        {
            Name = name;
        }
    }
}
