using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Entities;

namespace Linq.Exercises
{
    public class LinqExercises
    {
        public IEnumerable<Person> E01_Filter_Persons_With_FirstName_Starting_With_A(IEnumerable<Person> data)
        {
            return Enumerable.Empty<Person>();
        }

        public Person E02_Get_First_Person_In_List(IEnumerable<Person> data)
        {
            return null;
        }

        public Person E03_Get_Last_Person_In_List(IEnumerable<Person> data)
        {
            return null;
        }

        public IEnumerable<Person> E04_Get_All_Persons_From_Norway(IEnumerable<Person> data)
        {
            return Enumerable.Empty<Person>();
        }

        public Person E05_Get_The_Youngest_Person_From_Sweden(IEnumerable<Person> data)
        {
            return null;
        }

        public string E06_Get_The_Longest_Lastname_If_Equal_Length_Return_Alphabetically(IEnumerable<Person> data)
        {
            return string.Empty;
        }

        public bool? E07_Validate_That_All_Persons_In_List_Are_From_England(IEnumerable<Person> data)
        {
            return null;
        }

        public bool? E08_Validate_That_At_Least_One_Person_Is_From_Denmark(IEnumerable<Person> data)
        {
            return null;
        }

        public int E09_Get_The_Number_Of_Person_In_The_List(IEnumerable<Person> data)
        {
            return 0;
        }

        public int E10_Get_The_Total_Number_Of_Kids_From_All_Persons_Combined(IEnumerable<Person> data)
        {
            return 0;
        }

        public Nationality E11_Get_The_Nationality_With_The_Highest_Number_Of_Kids(IEnumerable<Person> data)
        {
            return Nationality.Unknown;
        }

        public IEnumerable<string> E12_Get_All_Phone_Numbers(IEnumerable<Person> data)
        {
            return Enumerable.Empty<string>();
        }

        public string E13_Create_A_String_That_Concats_FirstName_Of_Persons_Born_Before_1970_Ordered_By_Birthday_Descending(IEnumerable<Person> data)
        {
            return string.Empty;
        }

        public DateTime E14_Get_The_BirthDay_Of_The_Youngest_Person(IEnumerable<Person> data)
        {
            return DateTime.MinValue;
        }

        public DateTime E15_Get_The_BirthDay_Of_The_Oldest_Person(IEnumerable<Person> data)
        {
            return DateTime.MinValue;
        }

        public Person E16_1_Get_The_Person_With_The_Second_Highest_Number_Of_Kids(IEnumerable<Person> data)
        {
            return null;
        }

        public IEnumerable<Person> E17_Get_The_Two_Persons_With_The_Highest_Number_Of_Kids(IEnumerable<Person> data)
        {
            return Enumerable.Empty<Person>();
        }

    }
}
