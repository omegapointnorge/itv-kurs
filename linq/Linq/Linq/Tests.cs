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

        [TestInitialize()]
        public void Startup()
        {
            Persons = GetPersons();
        }

        [TestMethod]
        public void Filter_Persons_With_FirstName_Starting_With_A()
        {

            //TODO: Write linq
            var result = Persons.Where(x => x.FirstName.StartsWith("A"));
            ListsAreEqual(result, new List<int> { 1, 2, 3 });
        }

        [TestMethod]
        public void Get_First_Person_In_List()
        {
            //TODO: Write linq
            var result = Persons.FirstOrDefault();
            Assert.AreEqual(result.Id, 1);
        }


        [TestMethod]
        public void Get_Last_Person_In_List()
        {
            //TODO: Write linq
            var result = Persons.LastOrDefault();
            Assert.AreEqual(result.Id, 9);
        }

        [TestMethod]
        public void Get_Persons_Where_IDs_Are_Odd_Numbers()
        {
            //TODO: Write linq
            var result = Persons.Where(x => x.Id % 2 > 0);
            ListsAreEqual(result, new List<int> { 1, 3, 5, 7, 9 });
        }


        [TestMethod]
        public void Get_Persons_Where_IDs_Are_Even_Numbers()
        {
            var result = Persons.Where(x => x.Id % 2 == 0);

            //TODO: Update list Ids to pass test
            var listIds = new List<int> { 2, 4, 6, 8 };

            ListsAreEqual(result, listIds);
        }

        private void ListsAreEqual(IEnumerable<Person> persons, List<int> result)
        {
            CollectionAssert.AreEqual(persons.Select(x => x.Id).ToList(), result);
        }


        public List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person(1, "Anne", "Hansen", new DateTime(1990, 10, 10)),
                new Person(2, "Arvid", "Jensen", new DateTime(1999, 8, 2)),
                new Person(3, "Are", "Vidar", new DateTime(1986, 5, 3)),
                new Person(4, "Karl", "Lange", new DateTime(2001, 1, 1)),
                new Person(5, "Helle", "Karlsen", new DateTime(1927, 3, 5)),
                new Person(6, "Stine", "Bråthen", new DateTime(1970, 11, 1)),
                new Person(7, "Truls", "Krogh", new DateTime(1977, 03, 1)),
                new Person(8, "Bente", "Knek", new DateTime(1977, 03, 1)),
                new Person(9, "Petter", "Arvesen", new DateTime(1977, 03, 1))
            };
        }
    }

    public class Person
    {
        public DateTime Birthday { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public Person(int id, string firstName, string lastName, DateTime birthDay)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthDay;
            Id = id;
        }

    }
}
