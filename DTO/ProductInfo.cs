using System.Collections.Generic;

namespace DTO
{
    public class ProductInfo
    {
        public int Id { get; }
        public string Code { get; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public Dictionary<Ingredient, float> ActiveIngredient { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Country MadeIn { get; set; }
        public byte Expiry { get; set; }
        public Unit Unit { get; set; }
        public string StorageCondition { get; set; }
        public string Note { get; set; }
        public string Image { get; set; }
        public ProductInfo(int id, string code)
        {
            Id = id;
            Code = code;
            ActiveIngredient = new Dictionary<Ingredient, float>();
        }
        public ProductInfo(int id, string code, string name, Category category, Dictionary<Ingredient,float> activeIngredient, Manufacturer manufacturer, Country madeIn, byte expiry, Unit unit, string storageCondition, string note, string image)
        {
            Id = id;
            Code = code;
            Name = name;
            Category = category;
            ActiveIngredient = activeIngredient;
            Manufacturer = manufacturer;
            MadeIn = madeIn;
            Expiry = expiry;
            Unit = unit;
            StorageCondition = storageCondition;
            Note = note;
            Image = image;
        }
        public ProductInfo() { ActiveIngredient = new Dictionary<Ingredient, float>(); }
        public ProductInfo(string name, Category category, Dictionary<Ingredient,float> activeIngredient, Manufacturer manufacturer, Country madeIn, byte expiry, Unit unit, string storageCondition, string note, string image)
        {
            Name = name;
            Category = category;
            ActiveIngredient = activeIngredient;
            Manufacturer = manufacturer;
            MadeIn = madeIn;
            Expiry = expiry;
            Unit = unit;
            StorageCondition = storageCondition;
            Note = note;
            Image = image;
        }
        public void AddIngredient(Ingredient e, float dosage) { ActiveIngredient.Add(e, dosage); }
        
    }
}
