namespace DTO
{
    public class InventoryDetail
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public Unit Unit { get; set; }
        public int NumberOnSystem { get; set; }
        public int NumberActual { get; set; }
        public int NumberSubstandard { get => NumberActual - NumberStandard; set => NumberActual = value; }
        public int NumberStandard { get => NumberActual - NumberSubstandard; set => NumberActual = value; }
        public InventoryDetail(string barcode, string name, Unit unit, int numberOnSystem)
        {
            Barcode = barcode;
            Name = name;
            Unit = unit;
            NumberOnSystem = numberOnSystem;
        }
        public InventoryDetail(Product product)
        {
            Barcode = product.Information.Barcode;
            Name = product.Information.Name;
            Unit = product.Information.Unit;
            NumberOnSystem = product.Number;
        }
    }
}
