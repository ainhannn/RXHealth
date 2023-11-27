namespace DTO
{
    public class OrderProduct
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }
        public double CurrentImportPrice { get; set; }
        public int Number { get; set; }

        public override string ToString()
            => Barcode + Name + Category + Unit;

    }
}
