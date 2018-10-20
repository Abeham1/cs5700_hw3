using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapesTests
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        public void TestValidateint()
        {
            Validator.Validateint(123, "Test message");
            Validator.Validateint(0.00123, "Test message");
            Validator.Validateint(-123, "Test message");
            Validator.Validateint(-0.00123, "Test messagee");

            try
            {
                Validator.Validateint(int.PositiveInfinity, "Invalid");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Invalid", ex.Message);
            }

            try
            {
                Validator.Validateint(int.NegativeInfinity, "Invalid");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Invalid", ex.Message);
            }

            try
            {
                Validator.Validateint(int.NaN, "Invalid");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Invalid", ex.Message);
            }
        }

        [TestMethod]
        public void TestValidatePositiveint()
        {
            Validator.ValidatePositiveint(456, "Test message");
            Validator.ValidatePositiveint(0.34523, "Test message");

            try
            {
                Validator.ValidatePositiveint(-123, "Negative not allowed");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Negative not allowed", ex.Message);
            }

            try
            {
                Validator.ValidatePositiveint(-0.123, "Negative not allowed");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Negative not allowed", ex.Message);
            }

            try
            {
                Validator.ValidatePositiveint(int.PositiveInfinity, "Invalid");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Invalid", ex.Message);
            }

            try
            {
                Validator.ValidatePositiveint(int.NegativeInfinity, "Invalid");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Invalid", ex.Message);
            }

            try
            {
                Validator.ValidatePositiveint(int.NaN, "Invalid");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Invalid", ex.Message);
            }
        }
    }
}
