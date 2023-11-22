using System.Collections.Generic;

namespace DTO
{
    public class ProductOnSale
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }
        public double Saleprice { get; set; }
        public int Number { get; set; }
        public string RetailUnit { get; set; }
        public double RetailSaleprice { get; set; }
        public int RetailNumber { get; set; }

        public ProductOnSale() { }
    }
}
