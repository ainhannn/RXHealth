using System;


namespace DTO
{
    public class ProductBatch
    {
        public int Id { get; }
        public string LocalCode { get; }
        
        // chua xong


        public DateTime ManufactureDate { get; set; }
        public int Number { get; set; }
        public int NumberSubunit { get; set; }
        public float SaleUnitPrice { get; set; }
        public float SaleSubunitPrice { get; set; }
        
        
    }
}
