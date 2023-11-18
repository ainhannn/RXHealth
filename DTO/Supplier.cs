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
        public List<ImportDetail> Details { get; set; } = new List<ImportDetail>();

        public Supplier(int id) { Id = id; }
        public Supplier(int id, string name, string contactNumber, string address, List<ImportDetail> details)
        {
            Id = id;
            Name = name;
            ContactNumber = contactNumber;
            Address = address;
            Details = details;
        }
        public Supplier(string name, string contactNumber, string address)
        {
            Name = name;
            ContactNumber = contactNumber;
            Address = address;
        }
    }
}
