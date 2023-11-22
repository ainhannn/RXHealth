namespace DTO
{
    public class SaleDetail
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double UnitPrice { get; set; }
        public int Number { get; set; }
        public double Amount { get => UnitPrice * Number; }
        public SaleDetail() { }
        public SaleDetail(string barcode, string name, string unit, double unitPrice, int number)
        {
            Barcode = barcode;
            Name = name;
            Unit = unit;
            UnitPrice = unitPrice;
            Number = number;
        }
    }
}
