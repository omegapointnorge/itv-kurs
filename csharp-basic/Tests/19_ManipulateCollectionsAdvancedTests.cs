using System.Collections.Generic;
using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ManipulateCollectionsTestMethods
    {
        private readonly ManipulateCollectionsAdvanced _task = new();

        [TestMethod]
        public void Should_get_person_older_than20_sorted_by_height()
        {
            var filteredPersons = _task.PersonsOlderThan20SortedByHeight(TestMethodData.TestMethodPersons);

            Assert.AreEqual("Ken", filteredPersons[0].Name);
            Assert.AreEqual("Carl", filteredPersons[1].Name);
        }


        [TestMethod]
        public void Should_correlate_person_with_dog_on_dogId()
        {
            var personsWithDogNames = _task.PersonsWithDogs(TestMethodData.TestMethodPersons, TestMethodData.TestMethodDogs);

            Assert.AreEqual("Allison", personsWithDogNames[0].Name);
            Assert.AreEqual("Alex", personsWithDogNames[0].DogName);

            Assert.AreEqual("Carl", personsWithDogNames[1].Name);
            Assert.AreEqual("Bota", personsWithDogNames[1].DogName);
        }

        [TestMethod]
        public void Should_add_one_to_each_int()
        {
            var listOfInts = new List<int> {1, 2, 3, 4};

            var result = _task.Add1TooAll(listOfInts);

            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(4, result[2]);
            Assert.AreEqual(5, result[3]);
        }
    }
}