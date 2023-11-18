using System.Collections.Generic;

namespace DTO
{
    public class Customer
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public int TotalPoint { get; set; } = 0;
        public List<SaleDetail> PurchaseHistory { get; set; } = new List<SaleDetail>();
        public Customer(int id, string name, string contactNumber, int totalPoint)
        {
            Id = id;
            Name = name;
            ContactNumber = contactNumber;
            TotalPoint = totalPoint;
        }
        public Customer(string name, string contactNumber)
        {
            Name = name;
            ContactNumber = contactNumber;
        }
    }
}
