using System;

namespace DTO
{
    public class FormInvoice
    {
        public int Id { get; private set; }
        public string Code { get; private set; }
        public DateTime DateInit { get; set; } = DateTime.Now;
        public int StaffId { get; set; }
        public string StaffNickName { get; set; } //


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
