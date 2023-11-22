using System.Collections.Generic;

namespace DTO
{
    public class InvenProduct
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Unit { get; set; }
        public int ImportNumber { get; set; }
        public int NumberSoldOut { get; set; }
        public int TotalNumber { get; set; }
        public string RetailUnit { get; set; }
        public int RetailNumber { get; set; }
        public List<ProductBatch> Batches { get; set; }
    }
}