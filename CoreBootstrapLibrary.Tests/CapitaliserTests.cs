using System;
using Xunit;

namespace CoreBootstrapLibrary.Tests
{
    public class CapitaliserTests
    {
        [Fact]
        public void InputIsCapitalised()
        {
            // Arrange
            string input = "Is this a commentary on capitalism?";
            ICapitaliser capitaliser = new Capitaliser();

            // Act
            string output = capitaliser.Captialise(input);

            // Assert
            Assert.Equal("IS THIS A COMMENTARY ON CAPITALISM?", output);
        }
        
        [Fact]
        public void FailingTest()
        {
            throw new Exception("i failed on purpose");
        }
    }
}
