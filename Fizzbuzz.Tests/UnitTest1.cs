using Oponeo.UnitTests.Implementation;

namespace Fizzbuzz.Tests
{
    [TestClass]
    public class FizbuzzTests
    {
        [TestMethod]
        [DataRow(15)]
        [DataRow(30)]
        [DataRow(45)]
        [DataRow(60)]
        public void Returns_FizzBuzz_When_Number_Is_Divisible_By_3_And_5(int number)
        {
            // Arrange
            var fizbuzzer = new Fizbuzzer();

            // Act
            var result = fizbuzzer.FizzBuzz(number);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(9)]
        [DataRow(12)]
        [DataRow(18)]
        public void Returns_Fizz_When_Number_Is_Only_Divisible_By_3(int number)
        {
            // Arrange
            var fizbuzzer = new Fizbuzzer();

            // Act
            var result = fizbuzzer.FizzBuzz(number);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(20)]
        [DataRow(25)]
        public void Returns_Buzz_When_Number_Is_Only_Divisible_By_5(int number)
        {
            // Arrange
            var fizbuzzer = new Fizbuzzer();

            // Act
            var result = fizbuzzer.FizzBuzz(number);

            // Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(27)]
        public void Returns_Empty_String_When_Number_Is_Not_Divisible_By_3_Nor_5(int number)
        {
            // Arrange
            var fizbuzzer = new Fizbuzzer();

            // Act
            var result = fizbuzzer.FizzBuzz(number);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }
    }
}