using Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ManipulateStringsTestMethods
    {
        private readonly ManipulateTestMethodStrings _manipulateTestMethodStrings = new();

        [TestMethod]
        public void PlusOperatorConcatStrings()
        {
            var result = _manipulateTestMethodStrings.PlusOperatorConcatStrings();

            Assert.AreEqual("Hello World", result);
        }

        [TestMethod]
        public void FormatString()
        {
            var result = _manipulateTestMethodStrings.StringFormat();

            Assert.AreEqual("Hello to you too World", result);
        }

        [TestMethod]
        public void StringInterpolation()
        {
            var result = _manipulateTestMethodStrings.StringInterpolation();

            Assert.AreEqual("Hello to you too World", result);
        }
        
        [TestMethod]
        public void CheckForNullOrEmpty()
        {
            var result = _manipulateTestMethodStrings.CheckForNullOrEmpty("");

            Assert.AreEqual("Empty string", result);
        }
        
        [TestMethod]
        public void CheckForNullOrEmpty2()
        {
            var result = _manipulateTestMethodStrings.CheckForNullOrEmpty(null!);

            Assert.AreEqual("Empty string", result);
        }
        
        [TestMethod]
        public void CheckForNullOrEmpty3()
        {
            var result = _manipulateTestMethodStrings.CheckForNullOrEmpty("a");

            Assert.AreEqual("Hello World", result);
        }
        
        [TestMethod]
        public void CheckForNullOrEmpty4()
        {
            var result = _manipulateTestMethodStrings.CheckForNullOrEmpty("Hello World");

            Assert.AreEqual("Hello World", result);
        }
    }
}
