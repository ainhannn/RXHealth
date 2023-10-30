using System.Collections.Generic;

namespace DTO
{
    public class Provider
    {
        public int Id { get; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public double Debt { get; set; }
        public DateTimeCycle TimeCycle { get; set; } = new DateTimeCycle();
        public List<PaymentInvoice> Payments {  get; set; } = new List<PaymentInvoice>();
        public Provider(int id) { Id = id; }
        public Provider(int id, string name, string contactNumber, string address, double debt, DateTimeCycle timeCycle)
        {
            Id = id;
            Name = name;
            ContactNumber = contactNumber;
            Address = address;
            Debt = debt;
            TimeCycle = timeCycle;
        }
        public Provider(string name, string contactNumber, string address)
        {
            Name = name;
            ContactNumber = contactNumber;
            Address = address;
        }
    }
}
