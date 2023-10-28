namespace DTO
{
    public class ExportDetail
    {
        public string LocalCode { get; set; }
        public string Name { get; set; }
        public Unit Unit { get; set; }
        public int Number { get; set; }
        public string Reason { get; set; }
        public ExportDetail() { }
        public ExportDetail(string localCode, string name, Unit unit, int number, string reason)
        {
            LocalCode = localCode;
            Name = name;
            Unit = unit;
            Number = number;
            Reason = reason;
        }
    }
}
