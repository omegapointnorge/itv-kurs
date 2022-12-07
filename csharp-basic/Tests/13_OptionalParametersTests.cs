﻿using System;
using System.Reflection;
using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class OptionalParametersTestMethods
    {
        [TestMethod]
        public void Ctor_should_have_optional_parameter()
        {
            var type = typeof(OptionalParameters);
            var ctor = type.GetConstructor(new[] { typeof(int) });
            var instance = ctor!.Invoke(new[] { Type.Missing }) as OptionalParameters;
            var field = (int)type.GetField("_myNumber",
                BindingFlags.NonPublic |
                BindingFlags.Instance)!.GetValue(instance)!;
            Assert.AreEqual(0, field);
        }

        [TestMethod]
        public void OptionalStringParameter_should_work_with_one_parameter()
        {
            var optionalParameters = new OptionalParameters(1337);
            var method = optionalParameters.GetType().GetMethod("OptionalStringParameter");
            var result = method!.Invoke(optionalParameters, new[] { "Ole", Type.Missing });
            Assert.AreEqual("Hello Ole Olsen", result);
        }

        [TestMethod]
        public void CanFirstParameterBeOptional_should_work_with_one_parameter()
        {
            var optionalParameters = new OptionalParameters(1337);
            var method = optionalParameters.GetType().GetMethod("CanFirstParameterBeOptional");
            var result = method!.Invoke(optionalParameters, new[] { "Per", Type.Missing });
            Assert.AreEqual("Hello Per Olsen", result);
        }

        [TestMethod]
        public void CanFirstParameterBeOptional_should_work_with_no_parameters()
        {
            var optionalParameters = new OptionalParameters(1337);
            var method = optionalParameters.GetType().GetMethod("CanFirstParameterBeOptional");
            var result = method!.Invoke(optionalParameters, new[] { Type.Missing, Type.Missing });
            Assert.AreEqual("Hello Ole Olsen", result);
        }
    }
}
