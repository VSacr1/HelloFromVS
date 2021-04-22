using System;
using Xunit;
using ArithmeticApp;

namespace ArithmeticApp.Tests
{
    public class UtilityTest
    {
        [Fact]
        public void AddTest()
        {
            //Arrange
            Utility utility = new Utility();
            //Act
            var addTestResult = utility.Add(2, 1);
            //Assert
            Assert.Equal(3, addTestResult);
        }
        [Fact]
        public void SubtractTest()
        {
            Utility utility = new Utility();
            var subtractResult = utility.Subtract(10, 3);
            Assert.Equal(7, subtractResult);
        }
        [Fact]
        public void MultiplyTest()
        {
            Utility utility = new Utility();
            var multiplyResult = utility.Multiply(2, 3);
            Assert.Equal(6, multiplyResult);
        }
        [Fact]
        public void DivideTest()
        {
            Utility utility = new Utility();
            var divideResult = utility.Divide(51, 3);
            Assert.Equal(17, divideResult);
        }
    }
}
