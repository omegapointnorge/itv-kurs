using CodeQuality.E3_Functions;
using System.Linq;

namespace CodeQuality.S3_Functions
{
    public class NameDisplayer
    {
        public string AsShortendMiddleName(Person person)
        {
            return $"{person.FirstName} {person.MiddleName.First()}. {person.LastName}";
        }

        public string AsLastNameCapitalized(Person person)
        {
            return $"{person.FirstName} {person.MiddleName} {person.LastName.ToUpper()}";
        }

        public string AsPrefixedWithTitle(Person person)
        {
            var titlePrefix = person.Gender == Gender.Woman ? "Ms." : "Mr.";
            return $"{titlePrefix} {person.FirstName} {person.MiddleName} {person.LastName.ToUpper()}";
        }
    }


    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Gender Gender { get; set; }
    }
}
