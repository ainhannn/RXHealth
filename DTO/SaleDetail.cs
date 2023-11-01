namespace DTO
{
    public class SaleDetail
    {
        public string LocalCode { get; set; }
        public string Name { get; set; }
        public Unit Unit { get; set; }
        public float UnitPrice { get; set; }
        public int Number { get; set; }
        public float Amount { get => UnitPrice * Number; }
        public SaleDetail() { }
        public SaleDetail(string localCode, string name, Unit unit, float unitPrice, int number)
        {
            LocalCode = localCode;
            Name = name;
            Unit = unit;
            UnitPrice = unitPrice;
            Number = number;
        }
    }
}
