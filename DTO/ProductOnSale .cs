using System.Collections.Generic;

namespace DTO
{
    public class ProductOnSale
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }
        public float Saleprice { get; set; }
        public int Number { get; set; }
        public string RetailUnit { get; set; }
        public float RetailSaleprice { get; set; }
        public int RetailNumber { get; set; }

        public ProductOnSale() { }
        public ProductOnSale(string barcode, string name, string category, string unit, float saleprice, int number, string retailUnit, float retailSaleprice, int retailNumber)
        {
            Barcode = barcode;
            Name = name;
            Category = category;
            Unit = unit;
            Saleprice = saleprice;
            Number = number;
            RetailUnit = retailUnit;
            RetailSaleprice = retailSaleprice;
            RetailNumber = retailNumber;
        }
    }
}
