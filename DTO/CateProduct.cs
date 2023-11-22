namespace DTO
{
    public class CateProduct
    {
        public int Id { get; set; }
        public string Stack { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Unit { get; set; }
        public double CurrentImportPrice { get; set; }
        public double Saleprice { get; set; }
        public string RetailUnit { get; set; }
        public double RetailSaleprice { get; set; }
        public string ExtraInformation { get; set; }
        public string Image { get; set; }
        public bool IsOnSale { get; set; }
    }
}