using System;
using System.Collections.Generic;

namespace Linq.Entities
{
    public class Person
    {
        public DateTime Birthday { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public Nationality Nationality { get; set; }
        public int NumberOfKids { get; set; }
        public List<string> PhoneNumbers { get; set; }

        public Person(int id, string firstName, string lastName, DateTime birthDay, Nationality nationality, int numberOfKids, List<string> phoneNumbers)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthDay;
            Id = id;
            Nationality = nationality;
            NumberOfKids = numberOfKids;
            PhoneNumbers = phoneNumbers;
        }
    }
}
