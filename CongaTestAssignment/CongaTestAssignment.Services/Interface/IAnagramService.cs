using System.Collections.Generic;

namespace CongaTestAssignment.Services.Interfaces
{
    /// <summary>
    /// interface to check string is anagram or not.
    /// </summary>
    public interface IAnagramService
    {
        /// <summary>
        /// method to get string is anagram or not.
        /// </summary>
        /// <param name="inputString">user input string from console app.</param>
        /// <returns></returns>
        List<string> GetAnagramStrings(string inputString);
    }
}
