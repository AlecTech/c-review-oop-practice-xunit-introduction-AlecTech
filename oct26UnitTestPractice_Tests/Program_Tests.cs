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
    }
}
