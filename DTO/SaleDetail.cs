namespace DTO
{
    public class SaleDetail
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public float UnitPrice { get; set; }
        public int Number { get; set; }
        public float Amount { get => UnitPrice * Number; }
        public SaleDetail() { }
        public SaleDetail(string name, string unit, float unitPrice, int number)
        {
            Name = name;
            Unit = unit;
            UnitPrice = unitPrice;
            Number = number;
        }
    }
}
