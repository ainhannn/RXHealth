using System.Collections;
using System.Collections.Generic;

namespace DTO
{
    public class StoProduct
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Unit { get; set; }
        public int ImportNumber { get; set; }
        public int NumberSoldOut { get; set; }
        public int TotalNumber { get; set; }
        public int Capacity { get; set; }
        public string RetailUnit { get; set; }
        public int RetailNumber { get; set; }
        public List<ProductBatch> Batches { get; set; } = new List<ProductBatch>();

        public override string ToString()
            => Barcode + Name + Category.Name + Unit + RetailUnit;

    }
}