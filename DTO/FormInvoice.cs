using System;

namespace DTO
{
    public class FormInvoice
    {
        public int Id { get; }
        public string Code { get; }
        public DateTime DateInit { get; set; } = DateTime.Now;
        public string StaffNickName { get; set; }

        public FormInvoice() { }
        public FormInvoice(int id, string code)
        {
            Id = id;
            Code = code;
        }
        public FormInvoice(int id, string code, DateTime dateInit, string staffNickName)
        {
            Id = id;
            Code = code;
            DateInit = dateInit;
            StaffNickName = staffNickName;
        }
    }
}
