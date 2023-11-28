namespace DTO
{
    public class Address
    {
        public string Country { get; set; } = "Việt Nam";
        public string City { get; set; }
        public string District { get; set; }
        public string Detail { get; set; }

        public override string ToString() => string.Format("{0}{1}{2}{3}",
            Detail != null ? Detail + ", " : "",
            District != null ? District + ", " : "",
            City != null ? City + ", " : "",
            Country);
    }
}
