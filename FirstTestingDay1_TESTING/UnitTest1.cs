using System;
using Xunit;

namespace FirstTestingDay1_TESTING
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("raCecar", true)]
        [InlineData("raCeaR", true)]
        [InlineData("RACECAR", true)]
        [InlineData("maomom", false)]
        [InlineData("MAOMOM", false)]
        [InlineData("maoMom", false)]

      

        public static void BookNameReverse(string name, bool expected)
        {
            //Arrange
            FirstTestingDay1.Models.Book sut = new FirstTestingDay1.Models.Book();

            //Act

            bool actual = sut.SameWordBackwards(name);

            if (actual.GetType() == name.GetType())
            {
                expected = true;
            }
            else
            {
                expected = false;
            }
            //Assert
            Assert.Equal(expected, actual);
        }
    }
    public class UnitTest2
    {
        [Theory]
        [InlineData("hello", "olleh")]
        [InlineData("Hello", "olleH")]
        [InlineData("HELLO", "OLLEH")]

        public static void Reverse(string name, string expected)
        {
            //Arrange
            FirstTestingDay1.Models.Book sut = new FirstTestingDay1.Models.Book();
            //Act
            string actual = sut.ReverseString(name);
            //Assert
            Assert.Equal(expected, actual);

        }

    }

}
