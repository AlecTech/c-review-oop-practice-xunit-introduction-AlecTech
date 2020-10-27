using System;
using Xunit;
using oct26UnitTestPractice;

namespace oct26UnitTestPractice_Tests
{
    public class Program_Tests
    {
        [Theory]
        [InlineData(" YES", true)]
        [InlineData("Y ", true)]
        [InlineData("   NO", true)]
        [InlineData("N   ", true)]
        [InlineData(" ", false)]
        [InlineData("   ", false)]
        [InlineData("YES", true)]
        [InlineData("NO", true)]
        [InlineData("123", false)]

        public void IsYesOrNo_Test1(string input, bool expected)
        {
            // Arrange - Set up any data, variables, objects, etc necessary for testing.
            bool output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.IsYesOrNo(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }

        [Theory]
        [InlineData("yes", true)]
        [InlineData("nO", true)]
        [InlineData("yes1", false)]

        public void IsYesOrNo_Test2(string input, bool expected)
        {
            // Arrange - Set up any data, variables, objects, etc necessary for testing.
            bool output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.IsYesOrNo(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }

        [Theory]
        [InlineData("YES", true)]
        [InlineData("NO", true)]
        [InlineData("Y", true)]
        [InlineData("N", true)]

        public void IsYesOrNo_Test3(string input, bool expected)
        {
            // Arrange - Set up any data, variables, objects, etc necessary for testing.
            bool output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.IsYesOrNo(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }

        [Theory]
        [InlineData("n", true)]
        [InlineData("s", false)]
        [InlineData("", false)]

        public void IsYesOrNo_Test4(string input, bool expected)
        {
            // Arrange - Set up any data, variables, objects, etc necessary for testing.
            bool output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.IsYesOrNo(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }

        [Fact]
        public void Exception_Test1()
        {
            // Arrange - N/A

            // Act - N/A

            // Assert
            Assert.Throws<FormatException>(() => {
                // This code block should throw a Exception of the type in the angle brackets.
                Program.ThrowsFormatException();
            });
        }

        [Fact]
        public void Exception_Test2()
        {
            // Arrange - N/A

            // Act - N/A

            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => 
            { Program.ThrowsIndexOutOfRangeException(); });
        }

        [Fact]
        public void Exception_Test3()
        {
            // Arrange - N/A

            // Act - N/A

            // Assert
            static void p() => Program.ThrowsDivideByZero();
            Assert.Throws<DivideByZero>((Action)p);
        }

    }
}
