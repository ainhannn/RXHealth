using System.Collections.Generic;

namespace DTO
{
    public class Product
    {
        public ProductInfo Information { get; set; }
        public List<ProductBatch> Batches { get; set; } = new List<ProductBatch>();
        public string Stack { get; set; }
        public int Number { get; set; }
        public int NumberSubunit { get; set; }
        public int NumberAboutToExpire { get; set; }
        public float Rate { get; set; }
        public bool IsOnSale { get; set; }
        public Product() { }
        public Product(ProductInfo information, List<ProductBatch> batches, string stack, int number, int numberSubunit, int numberAboutToExpire, float rate, bool isOnSale)
        {
            Information = information;
            Batches = batches;
            Stack = stack;
            Number = number;
            NumberSubunit = numberSubunit;
            NumberAboutToExpire = numberAboutToExpire;
            Rate = rate;
            IsOnSale = isOnSale;
        }
    }
}
