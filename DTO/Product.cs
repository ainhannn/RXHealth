using System.Collections.Generic;

namespace DTO
{
    public class Product
    {
        public int Id { get; }
        public string Stack { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public byte Expiry { get; set; }
        public string Unit { get; set; }
        public float CurrentImportPrice { get; set; } //
        public float Saleprice { get; set; }
        public int NumberSoldOut { get; set; } // 
        public int TotalNumber { get; set; } // 
        public string RetailUnit { get; set; }
        public double RetailSaleprice { get; set; }
        public int RetailNumber { get; set; }
        public string ExtraInformation { get; set; }
        public string Image { get; set; }
        public bool IsOnSale { get; set; } = true;
        public List<ProductBatch> Batches { get; set; } = new List<ProductBatch>();

        public Product(int id)
        {
            Id = id;
        }
        public void AddProductBatch(ProductBatch batch) => Batches.Add(batch);
    }
}
