using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class LinqSolutions
    {
        public IEnumerable<Person> S1_Filter_Persons_With_FirstName_Starting_With_A(IEnumerable<Person> data)
        {
            return data.Where(x => x.FirstName.StartsWith("A"));
        }

        public Person S2_Get_First_Person_In_List(IEnumerable<Person> data)
        {
            return data.First();
        }

        public Person S3_Get_Last_Person_In_List(IEnumerable<Person> data)
        {
            return data.Last();
        }

        public IEnumerable<Person> S4_Get_All_Persons_From_Norway(IEnumerable<Person> data)
        {
            return data.Where(x => x.Nationality == Nationality.Norwegian);
        }

        public Person S5_Get_The_Youngest_Person_From_Sweden(IEnumerable<Person> data)
        {
            return data.OrderByDescending(x => x.Birthday).First(x => x.Nationality == Nationality.Swedish);
        }

        public string S6_Get_The_Longest_Lastname_If_Equal_Length_Return_Alphabetically(IEnumerable<Person> data)
        {
            return data.OrderByDescending(x => x.LastName.Length)
                .ThenBy(x => x.LastName)
                .Select(x => x.LastName)
                .First();
        }

        public bool S7_Validate_That_All_Persons_In_List_Are_From_England(IEnumerable<Person> data)
        {
            return data.All(x => x.Nationality == Nationality.English);
        }

        public bool S8_Validate_That_At_Least_One_Person_Is_From_Danmark(IEnumerable<Person> data)
        {
            return data.Any(x => x.Nationality == Nationality.Danish);
        }

        public int S9_Get_The_Number_Of_Person_In_The_List(IEnumerable<Person> data)
        {
            return data.Count();
        }

        public int S10_Get_The_Number_Of_Kids_Combined(IEnumerable<Person> data)
        {
            return data.Sum(x => x.NumberOfKids);
        }

        public Nationality S11_Get_The_Nationality_With_The_Highest_Number_Of_Kids(IEnumerable<Person> data)
        {
            var grouping = data.GroupBy(x => x.Nationality)
                .Select(x => new { sum = x.Sum(kids => kids.NumberOfKids), nationality = x.Key });

            var result = grouping
              .OrderByDescending(x => x.sum)
              .Select(x => x.nationality)
              .First();

            return result;
        }

        public IEnumerable<string> S12_Get_All_Phone_Numbers(IEnumerable<Person> data)
        {
            return data.SelectMany(x => x.PhoneNumbers);
        }

        public string S13_Create_A_String_That_Concats_FirstName_Of_Persons_Born_Before_1970_Ordered_By_Birthday_Descending(IEnumerable<Person> data)
        {
            var names = data
                .Where(x => x.Birthday.Year < 1970)
                .OrderByDescending(x => x.Birthday)
                .Select(x => x.FirstName)
                .Aggregate((acc, firstname) => acc + firstname);
            return names;
        }

        public DateTime S14_Get_The_BirthDay_Of_The_Youngest_Person(IEnumerable<Person> data)
        {
            return data.Max(x => x.Birthday);
        }

        public DateTime S15_Get_The_BirthDay_Of_The_Oldest_Person(IEnumerable<Person> data)
        {
            return data.Min(x => x.Birthday);
        }

        public Person S16_1_Get_The_Person_With_The_Second_Highest_Number_Of_Kids(IEnumerable<Person> data)
        {
            return data.OrderByDescending(x => x.NumberOfKids).Skip(1).FirstOrDefault();
        }

        public IEnumerable<Person> S17_Get_The_Two_Persons_With_The_Highest_Number_Of_Kids(IEnumerable<Person> data)
        {
            return data.OrderByDescending(x => x.NumberOfKids).Take(2);
        }

    }

}
