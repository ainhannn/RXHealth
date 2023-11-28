namespace DTO
{
    public interface CateProduct
    {
        int Id { get; }
        string Stack { get; set; }
        string Barcode { get; set; }
        string Name { get; set; }
        Category Category { get; set; }
        string Unit { get; set; }
        float CurrentImportPrice { get; set; } //
        float Saleprice { get; set; }
        int NumberSoldOut { get; set; } // 
        int TotalNumber { get; set; } // 
        string RetailUnit { get; set; }
        float RetailSaleprice { get; set; }
        int RetailNumber { get; set; }
        string ExtraInformation { get; set; }
        string Image { get; set; }
        bool IsOnSale { get; set; } = true;
    }
}
