using System.Collections.Generic;
using System.Linq;
using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ManipulateCollectionTests
    {
        private readonly ManipulateCollections _task = new();


        [TestMethod]
        public void Should_change_elements_to_be_only_first_character()
        {
            IEnumerable<string> listOfStrings = new List<string> { "Keep", "It", "Stupid", "Simple" };
            Assert.AreEqual(_task.FirstCharacterOfEachString(listOfStrings).Aggregate((x, y) => x + y), "KISS");
        }

        [TestMethod]
        public void Should_contain_only_elements_starting_with_A()
        {
            IEnumerable<string> listOfStrings = new List<string> { "Allison", "Michael", "John", "Anna", "Julie" };
            var result = _task.FilterElementsStartingWithA(listOfStrings);
            Assert.IsTrue(result.Contains("Allison"));
            Assert.IsTrue(result.Contains("Anna"));
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Should_order_by_length()
        {
            IEnumerable<string> listOfStrings = new List<string> { "Sebastian", "Ken", "Alice" };
            var result = _task.OrderByLengthOfStrings(listOfStrings);

            Assert.AreEqual(result[0], "Ken");
            Assert.AreEqual(result[1], "Alice");
            Assert.AreEqual(result[2], "Sebastian");
        }

        [TestMethod]
        public void Should_return_average_of_even_numbers()
        {
            var listOfDigits = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.AreEqual(6, _task.GetAverageOfAllEvenNumbers(listOfDigits));
        }
    }
}