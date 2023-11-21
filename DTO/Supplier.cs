using System.Collections.Generic;

namespace DTO
{
    public class Supplier
    {
        public int Id { get; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public int Times { get; set; } = 0;
        public List<ImportInvoice> ExchangeHistory { get; set; } = new List<ImportInvoice>();

        public Supplier(int id) { Id = id; }

        public Supplier(string name, string contactNumber, string address)
        {
            Name = name;
            ContactNumber = contactNumber;
            Address = address;
        }
    }
}
