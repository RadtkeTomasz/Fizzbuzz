using Oponeo.UnitTests.Implementation;

namespace Fizzbuzz.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        [DataRow(-5)]
        public void Should_Throw_ArgumentOutOfRangeException_When_Index_Below_0(int index)
        {
            try
            {
                // Arrange
                var fibonacci = new Fibonacci();

                // Act
                fibonacci.CalculateFibonacciIndexValue(index);

                // Assert
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        [DataRow(-5)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Should_Throw_ArgumentOutOfRangeException_When_Index_Below_0_Attribute(int index)
        {
            // Arrange
            var fibonacci = new Fibonacci();

            // Act
            fibonacci.CalculateFibonacciIndexValue(index);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        [DataRow(5)]
        public void Should_Return_5_When_Index_Is_5(int index)
        {
            // Arrange
            var fibonacci = new Fibonacci();

            // Act
            var result = fibonacci.CalculateFibonacciIndexValue(index);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}
