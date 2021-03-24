using CongaTestAssignment.Services;
using System.Collections.Generic;
using Xunit;

namespace CongaTestAssignment.Test.Implementation
{
    public class AnagramServiceTests
    {
        /// <summary>
        /// Test case method to test Anagram string.
        /// </summary>
        [Theory]
        [MemberData(nameof(Data))]
        public void GetAnagramStringsTest(string inputString, List<string> expectedResult)
        {
            // Arrange
            //string inputString = "silent";
            //List<string> expectedResult = new List<string>() { "listen", "silent" };

            // Act
            AnagramService anagramService = new AnagramService();
            List<string> result = anagramService.GetAnagramStrings(inputString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[]{ "silent", new List<string> { "listen", "silent" } },
                new object[]{"dad", new List<string> { "add","dad" } },
                new object[]{ "air", new List<string> { "air" } },
                new object[]{ "air1", new List<string> {  } },
            };
    }
}
