using System;

namespace DTO
{
    public class Staff
    {
        public int Id { get; }
        public string Nickname { get; }
        public string CitizenId { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public bool GenderIsMale { get; set; }
        public string Qualification { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime ResignationDate { get; set; }
        public Staff(int id, string nickname)
        {
            Id = id;
            Nickname = nickname;
        }
        public Staff(int id, string nickname, string citizenId, string fullName, DateTime birthday, bool genderIsMale, string qualification, string contactNumber, string address, DateTime startDate, DateTime resignationDate)
        {
            Id = id;
            Nickname = nickname;
            CitizenId = citizenId;
            FullName = fullName;
            Birthday = birthday;
            GenderIsMale = genderIsMale;
            Qualification = qualification;
            ContactNumber = contactNumber;
            Address = address;
            StartDate = startDate;
            ResignationDate = resignationDate;
        }
        public Staff(string nickname)
        {
            Nickname = nickname;
        }
        public Staff(string nickname, string citizenId, string fullName, DateTime birthday, bool genderIsMale, string qualification, string contactNumber, string address, DateTime startDate)
        {
            Nickname = nickname;
            CitizenId = citizenId;
            FullName = fullName;
            Birthday = birthday;
            GenderIsMale = genderIsMale;
            Qualification = qualification;
            ContactNumber = contactNumber;
            Address = address;
            StartDate = startDate;
        }

        public Staff()
        {
        }
    }
}
