using System;

namespace DTO
{
    public class ImportDetail
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public DateTime MFGDate { get; set; } = DateTime.MinValue;
        public DateTime EXPDate { get; set; } = DateTime.MaxValue;
        public string Unit { get; set; }
        public int Number { get; set; }
        public float ImportPrice { get; set; }
        public ImportDetail() { }
    }
}
