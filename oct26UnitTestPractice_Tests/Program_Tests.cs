using System;
using Xunit;
using oct26UnitTestPractice;

namespace oct26UnitTestPractice_Tests
{
    public class Program_Tests
    {
        [Theory]
        [InlineData(2, 1)]
        [InlineData(4, 2)]
        [InlineData(3, 1)]
        [InlineData(0, 0)]
        [InlineData(-2, -1)]
        [InlineData(int.MaxValue, 1073741823)]
        [InlineData(int.MinValue, -1073741824)]
        public void DivideByTwo_Valid(int input, int expected)
        {
            // Arrange - Set up any data, variables, objects, etc necessary for testing.
            int output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.DivideByTwo(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }


        [Theory]
        // Lowest True
        [InlineData(4, true)]
        [InlineData(1, true)]
        // Lowest Falses
        [InlineData(3, false)]
        [InlineData(2, false)]
        // Max True
        [InlineData(2147395600, true)]
        // Max False
        [InlineData(int.MaxValue, false)]
        // Zero
        [InlineData(0, true)]
        // Min Negative
        [InlineData(-1, false)]
        // Negative of Min True
        [InlineData(-4, false)]
        // Max Negative
        [InlineData(int.MinValue, false)]
        public void PerfectSquare_Valid(int input, bool expected)
        {
            // Arrange - Set up any data, variables, objects, etc necessary for testing.
            bool output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.PerfectSquare(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }

        // Facts are for testing things that should always be true and do not require data sets.
        [Fact]
        public void MathPi_Value()
        {
            // Arrange - N/A

            // Act - N/A

            // Assert
            Assert.Equal(3.1415926535897931, Math.PI);
        }

        [Fact]
        public void Exception_Test()
        {
            // Arrange - N/A

            // Act - N/A

            // Assert
            Assert.Throws<FormatException>(() => {
                // This code block should throw a Exception of the type in the angle brackets.
                Program.ThrowsFormatException();
            });
        }
    }
}
