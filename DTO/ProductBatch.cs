using System;


namespace DTO
{
    public class ProductBatch
    {
        public int Id { get; }
        public string LocalCode { get; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ImportDate { get; set; }
        public int Number { get; set; }
        public int NumberSubunit { get; set; }
        public float ImportUnitPrice { get; set; }
        public float SaleUnitPrice { get; set; }
        public float SaleSubunitPrice { get; set; }
        public Provider Provider { get; set; }

        public ProductBatch(int id, string localCode, DateTime manufactureDate, DateTime importDate, int number, int numberSubunit, float importUnitPrice, float saleUnitPrice, float saleSubunitPrice, Provider provider)
        {
            Id = id;
            LocalCode = localCode;
            ManufactureDate = manufactureDate;
            ImportDate = importDate;
            Number = number;
            NumberSubunit = numberSubunit;
            ImportUnitPrice = importUnitPrice;
            SaleUnitPrice = saleUnitPrice;
            SaleSubunitPrice = saleSubunitPrice;
            Provider = provider;
        }

        public ProductBatch(int id, string localCode)
        {
            Id = id;
            LocalCode = localCode;
        }
    }
}
