﻿using System.Collections.Generic;
using System.Reflection;
using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class FunWithGenericsTestMethods
    {
        private readonly FunWithGenerics _funWithGenerics = new();
        private readonly FunWithGenerics3 _funWithGenerics3 = new();
        private readonly FunWithGenerics4 _funWithGenerics4 = new();

        [TestMethod]
        public void MyVeryOwnListShouldTakeGenericParameter()
        {
            var types = _funWithGenerics.GetType().GetNestedTypes(BindingFlags.Public);
            var myVeryOwnList = types[0];
            var genericTypeArguments = myVeryOwnList.GetGenericArguments().Length;

            Assert.AreEqual(1, genericTypeArguments);
        }

        [TestMethod]
        public void MyVeryOwnList2ShouldHaveGenericArray()
        {
            var myVeryOwnList2 = new FunWithGenerics2.MyVeryOwnListWithGenericArray<int>();

            var testMethod = new[] { 1, 2 };

            var properties = myVeryOwnList2.GetType().GetProperties();

            if (properties.Length == 1)
            {
                Assert.AreEqual(testMethod.GetType(), properties[0].PropertyType);
            }
            else
            {
                Assert.AreEqual(true, false);
            }
            
        }

        [TestMethod]
        public void MyVeryOwnListWithGenericAddMethod()
        {
            var myVeryOwnList3 = new FunWithGenerics3.MyVeryOwnListWithGenericAddMethod<int>
            {
                List = new List<int> { 1, 2 }
            };

            var types = _funWithGenerics3.GetType().GetNestedTypes(BindingFlags.Public);

            var constructed = types[0].MakeGenericType(myVeryOwnList3.GetType().GenericTypeArguments);

            var addMethod = constructed.GetMethod("Add");

            addMethod!.Invoke(myVeryOwnList3, new object[] {3});

            var expected = new[] { 1, 2, 3 };

            Assert.AreEqual(expected.Length, myVeryOwnList3.List.Count);
            Assert.AreEqual(expected[0], myVeryOwnList3.List[0]);
            Assert.AreEqual(expected[1], myVeryOwnList3.List[1]);
            Assert.AreEqual(expected[2], myVeryOwnList3.List[2]);
        }

        [TestMethod] 
        public void MyVeryOwnListWithSumAll()
        {
            var myVeryOwnList4 = new FunWithGenerics4.MyVeryOwnListWithSumAll<FunWithGenerics4.ISummable>();

            var testMethod1 = new Summable(1);
            var testMethod2 = new Summable(2);
            var testMethod3 = new Summable(3);

            var types = _funWithGenerics4.GetType().GetNestedTypes(BindingFlags.Public);
            var constructed = types[1].MakeGenericType(myVeryOwnList4.GetType().GenericTypeArguments);

            var addMethod = constructed.GetMethod("Add");

            addMethod!.Invoke(myVeryOwnList4, new object[] { testMethod1 });
            addMethod.Invoke(myVeryOwnList4, new object[] { testMethod2 });
            addMethod.Invoke(myVeryOwnList4, new object[] { testMethod3 });

            var sumAllMethod = constructed.GetMethod("SumAll");

            var value = sumAllMethod!.Invoke(myVeryOwnList4, null);

            Assert.AreEqual(6, value);
        }


        public class Summable : FunWithGenerics4.ISummable
        {
            private readonly int _number;

            public Summable(int number)
            {
                _number = number;
            }

            public int Sum()
            {
                return _number;
            }
        }
    }
}
