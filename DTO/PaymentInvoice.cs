using System;
using System.Collections.Generic;

namespace DTO
{
    public class PaymentInvoice
    {
        public int Id { get; }
        public string Code { get; }
        public DateTime InvoiceDate { get; set; }
        public string StaffNickName { get; set; }
        public Provider Provider { get; set; }
        public string Content { get; set; }
        public double Amount { get; set; }
        public double Paid { get; set; }
        public double Remain { get => Amount - Paid; }
        public PaymentInvoice(int id, string code)
        {
            Id = id;
            Code = code;
            InvoiceDate = DateTime.Now;
        }
        public PaymentInvoice(int id, string code, DateTime invoiceDate, string staffNickName, Provider provider, string content, double amount, double paid)
        {
            Id = id;
            Code = code;
            InvoiceDate = invoiceDate;
            StaffNickName = staffNickName;
            Provider = provider;
            Content = content;
            Amount = amount;
            Paid = paid;
        }
    }
}
