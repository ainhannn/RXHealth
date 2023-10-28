using System;

namespace DTO
{
    public class PaymentInvoice : FormInvoice
    {
        public Provider Provider { get; set; }
        public string Content { get; set; }
        public double Amount { get; set; }
        public double Paid { get; set; }
        public double Remain { get => Amount - Paid; }

        public PaymentInvoice() { }
        public PaymentInvoice(int id, string code) : base(id,code) { }
        public PaymentInvoice(int id, string code, DateTime dateInit, string staffNickName, Provider provider, string content, double amount, double paid) : base(id, code, dateInit, staffNickName)
        {
            Provider = provider;
            Content = content;
            Amount = amount;
            Paid = paid;
        }
    }
}