using System;

namespace CodeQuality.E1_Readability
{
    public class Customer
    {
        public DateTime BirthDay { get; internal set; }
        public int Age { get; internal set; }
        public int NumberOfYearsAsClient { get; internal set; }
    }
}