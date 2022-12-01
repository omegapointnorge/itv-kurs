using System.Collections.Generic;
using System.Linq;
using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PolymorphismTestMethods
    {

        [TestMethod]
        public void Should_get_sum_of_all_sizes()
        {
            var task = new OverloadShapes
            {
                Shapes = new List<Shape> {new(), new Circle(), new Line()}
            };

            var sizeSum = task.Shapes.Sum(s => s.Size);

            Assert.AreEqual(12, sizeSum);
            Assert.AreEqual(12, task.SumOfSize());

        }


    }
}
