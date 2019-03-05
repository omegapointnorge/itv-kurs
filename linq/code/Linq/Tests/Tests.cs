using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    [TestClass]
    public class LinqTests
    {
        public List<Person> Persons { get; set; }
        public LinqExercises Exercises { get; set; }
        public LinqSolutions Solutions { get; set; }

        [TestInitialize()]
        public void Startup()
        {
            Persons = GetPersons();
            Exercises = new LinqExercises();
            Solutions = new LinqSolutions();
        }

        [TestMethod]
        public void T1_1_Filter_Persons_With_FirstName_Starting_With_A()
        {
            var result = Exercises.E1_Filter_Persons_With_FirstName_Starting_With_A(Persons);
            ListsAreEqual(new List<int> { 1, 2, 3 }, result);
        }

        [TestMethod]
        public void T2_1_Get_First_Person_In_List()
        {
            var result = Exercises.E2_Get_First_Person_In_List(Persons);
            Assert.AreEqual(1, result.Id);
        }

        [TestMethod]
        public void T3_1_Get_Last_Person_In_List()
        {
            var result = Exercises.E3_Get_Last_Person_In_List(Persons);
            Assert.AreEqual(9, result.Id);
        }

        [TestMethod]
        public void T4_1_Get_All_Persons_From_Norway()
        {
            var result = Exercises.E4_Get_All_Persons_From_Norway(Persons);
            ListsAreEqual(new List<int> { 1, 5, 7, 9 }, result);
        }

        [TestMethod]
        public void T5_1_Get_The_Youngest_Person_From_Sweden()
        {
            var result = Exercises.E5_Get_The_Youngest_Person_From_Sweden(Persons);
            Assert.AreEqual(3, result.Id);
        }

        [TestMethod]
        public void T6_1_Get_The_Longest_Lastname_If_Equal_Length_Return_Alphabetically()
        {
            var result = Exercises.E6_Get_The_Longest_Lastname_If_Equal_Length_Return_Alphabetically(Persons);
            Assert.AreEqual("Arvesen", result);
        }

        [TestMethod]
        public void T7_1_Validate_That_All_Persons_In_List_Are_From_England_Return_True_If_Only_EnglishMen_Present()
        {
            var result = Exercises.E7_Validate_That_All_Persons_In_List_Are_From_England(Persons.Where(x => x.Nationality == Nationality.English));
            Assert.IsTrue(result.Value);
        }

        [TestMethod]
        public void T7_2_Validate_That_All_Persons_In_List_Are_From_England_Returns_False_If_Other_Nationality_Is_Present()
        {
            var result = Exercises.E7_Validate_That_All_Persons_In_List_Are_From_England(Persons);
            Assert.IsFalse(result.Value);
        }

        [TestMethod]
        public void T8_1_Validate_That_At_Least_One_Person_Is_From_Danmark_Returns_True_If_One_Danish_Exists()
        {
            var result = Exercises.E8_Validate_That_At_Least_One_Person_Is_From_Danmark(Persons);
            Assert.IsTrue(result.Value);
        }

        [TestMethod]
        public void T8_2_Validate_That_At_Least_One_Person_Is_From_Danmark_Returns_False_If_No_Danish_Exists()
        {
            var result = Exercises.E8_Validate_That_At_Least_One_Person_Is_From_Danmark(Persons.Where(x => x.Nationality != Nationality.Danish));
            Assert.IsFalse(result.Value);
        }

        [TestMethod]
        public void T9_1_Get_The_Number_Of_Persons_In_The_List()
        {
            var result = Exercises.E9_Get_The_Number_Of_Person_In_The_List(Persons);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void T10_1_Get_The_Number_Of_Kids_Combined()
        {
            var result = Exercises.E10_Get_The_Total_Number_Of_Kids_From_All_Persons_Combined(Persons);
            Assert.AreEqual(17, result);
        }

        [TestMethod]
        public void T11_1_Get_The_Nationality_With_The_Highest_Number_Of_Kids()
        {
            var result = Exercises.E11_Get_The_Nationality_With_The_Highest_Number_Of_Kids(Persons);
            Assert.AreEqual(Nationality.English, result);
        }

        [TestMethod]
        public void T12_1_Get_All_Phone_Numbers()
        {
            var result = Exercises.E12_Get_All_Phone_Numbers(Persons);
            ListsAreEqual(new List<string> { "98564732", "49030398", "98564732", "44338867", "44556677", "91236474", "95498752", "91009080" },
                result);
        }

        [TestMethod]
        public void T13_1_Create_A_String_That_Concats_FirstNames_Of_Persons_Born_Before_1970_Ordered_By_Birthday_Descending()
        {
            var result = Exercises.E13_Create_A_String_That_Concats_FirstName_Of_Persons_Born_Before_1970_Ordered_By_Birthday_Descending(Persons);

            Assert.AreEqual("BenteHelle", result);
        }

        [TestMethod]
        public void E14_1_Get_The_BirthDay_Of_The_Youngest_Person()
        {
            var result = Exercises.E14_Get_The_BirthDay_Of_The_Youngest_Person(Persons);
            Assert.AreEqual(new DateTime(2001, 1, 1), result);
        }

        [TestMethod]
        public void E15_1_Get_The_BirthDay_Of_The_Oldest_Person()
        {
            var result = Exercises.E15_Get_The_BirthDay_Of_The_Oldest_Person(Persons);
            Assert.AreEqual(new DateTime(1927, 3, 5), result);
        }

        [TestMethod]
        public void E16_Get_The_Person_With_The_Second_Highest_Number_Of_Kids()
        {
            var result = Exercises.T16_1_Get_The_Person_With_The_Second_Highest_Number_Of_Kids(Persons);
            Assert.AreEqual(9, result.Id);
        }

        [TestMethod]
        public void E17_1_Get_The_Two_Persons_With_The_Highest_Number_Of_Kids()
        {
            var result = Exercises.T17_Get_The_Two_Persons_With_The_Highest_Number_Of_Kids(Persons);
            ListsAreEqual(new List<int> { 4, 9 }, result);
        }

        private void ListsAreEqual(List<int> expected, IEnumerable<Person> result)
        {
            CollectionAssert.AreEqual(result.OrderBy(x => x.Id).Select(x => x.Id).ToList(), expected.OrderBy(x => x).ToList());
        }

        private void ListsAreEqual(List<string> expected, IEnumerable<string> result)
        {
            CollectionAssert.AreEqual(result.OrderBy(x => x).ToList(), expected.OrderBy(x => x).ToList());
        }

        public List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person(1, "Anne", "Hansen", new DateTime(1990, 10, 10), Nationality.Norwegian, 1, new List<string>{"98564732", "49030398" }),
                new Person(2, "Arvid", "Jensen", new DateTime(1999, 8, 2) , Nationality.Danish, 0, new List<string>()),
                new Person(3, "Are", "Vidar", new DateTime(1986, 5, 3), Nationality.Swedish, 2, new List<string>{"98564732", "44338867" }),
                new Person(4, "Karl", "Lange", new DateTime(2001, 1, 1) , Nationality.English, 8, new List<string>{}),
                new Person(5, "Helle", "Karlsen", new DateTime(1927, 3, 5), Nationality.Norwegian, 0, new List<string>{"44556677" }),
                new Person(6, "Stine", "Br�then", new DateTime(1970, 11, 1), Nationality.Swedish,2, new List<string>{ }),
                new Person(7, "Truls", "Krogh", new DateTime(1977, 03, 1), Nationality.Norwegian, 1, new List<string>{"91236474", "95498752" }),
                new Person(8, "Bente", "Knek", new DateTime(1967, 03, 1), Nationality.Swedish, 0, new List<string>{ }),
                new Person(9, "Petter", "Arvesen", new DateTime(1977, 03, 1), Nationality.Norwegian, 3, new List<string>{"91009080"})
            }.OrderBy(x => x.Id).ToList();
        }
    }

}