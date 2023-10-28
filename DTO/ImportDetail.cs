namespace DTO
{
    public class ImportDetail
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public Unit Unit { get; set; }
        public int NumberOrder { get; set; }
        public int NumberActual { get; set; }
        public float UnitPrice { get; set; }
        public ImportDetail() { }
        public ImportDetail(string barcode, string name, Unit unit, int numberOrder, int numberActual, float unitPrice)
        {
            Barcode = barcode;
            Name = name;
            Unit = unit;
            NumberOrder = numberOrder;
            NumberActual = numberActual;
            UnitPrice = unitPrice;
        }
    }
}
