namespace DTO
{
    public class OrderDetail
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public Unit Unit { get; set; }
        public int Number { get; set; }
        public OrderDetail() { }
        public OrderDetail(string barcode, string name, Unit unit, int number)
        {
            Barcode = barcode;
            Name = name;
            Unit = unit;
            Number = number;
        }
    }
}
