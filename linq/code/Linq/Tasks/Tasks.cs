using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Tasks
    {

        public IEnumerable<Person> E1_Filter_Persons_With_FirstName_Starting_With_A(IEnumerable<Person> data)
        {
            return data.Where(x => x.FirstName.StartsWith("A"));
            return Enumerable.Empty<Person>();
        }

        public Person E2_Get_First_Person_In_List(IEnumerable<Person> data)
        {
            return data.First();
            return new Person();
        }

        public Person E3_Get_Last_Person_In_List(IEnumerable<Person> data)
        {
            return data.Last();
            return new Person();
        }

        public IEnumerable<Person> E4_Get_All_Persons_From_Norway(IEnumerable<Person> data)
        {
            return data.Where(x => x.Nationality == Nationality.Norwegian);
            return Enumerable.Empty<Person>();
        }

        public Person E5_Get_The_Youngest_Person_From_Sweden(IEnumerable<Person> data)
        {
            return data.OrderByDescending(x => x.Birthday).First(x => x.Nationality == Nationality.Swedish);
            return new Person();

        }

        public string E6_Get_The_Longest_Lastname_If_Equal_Length_Return_Alphabetically(IEnumerable<Person> data)
        {
            return data.OrderByDescending(x => x.LastName.Length)
                .ThenBy(x => x.LastName)
                .Select(x => x.LastName)
                .First();
            return "";
        }


        public bool E7_Validate_That_All_Persons_In_List_Are_From_England(IEnumerable<Person> data)
        {
            return data.All(x => x.Nationality == Nationality.English);
            return false;
        }

        public bool E8_Validate_That_At_Least_One_Person_Is_From_Danmark(IEnumerable<Person> data)
        {
            return data.Any(x => x.Nationality == Nationality.Danish);
            return false;
        }

        public int E90_Get_The_Number_Of_Person_In_The_List(IEnumerable<Person> data)
        {
            return data.Count();
            return 0;
        }


        public int E10_Get_The_Number_Of_Kids_Combined(IEnumerable<Person> data)
        {
            return data.Sum(x => x.NumberOfKids);
            return 0;
        }

        public Nationality E11_Get_The_Nationality_With_The_Highest_Number_Of_Kids(IEnumerable<Person> data)
        {
            var grouping = data.GroupBy(x => x.Nationality)
                .Select(x => new { sum = x.Sum(kids => kids.NumberOfKids), nationality = x.Key });

            var result = grouping
              .OrderByDescending(x => x.sum)
              .Select(x => x.nationality)
              .First();   
            
            return result;

            return Nationality.Unknown;

        }  
        
        
        public IEnumerable<string> E12_Get_All_Phone_Numbers(IEnumerable<Person> data)
        {
            return data.SelectMany(x => x.PhoneNumbers); 
            return Enumerable.Empty<string>();

        }

    }


}
