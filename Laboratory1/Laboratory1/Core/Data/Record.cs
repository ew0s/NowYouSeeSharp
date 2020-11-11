using System;

namespace Laboratory1.Core.DATA
{
    public class Record
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public long MobileNumber { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }
        public string OtherNotes { get; set; }

        public Record(string firstName, string lastName, long mobileNumber, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            Country = country;
        }

        public override string ToString()
        {
            return $"{LastName} -=- {FirstName} -=- {MobileNumber}";
        }
    }
}