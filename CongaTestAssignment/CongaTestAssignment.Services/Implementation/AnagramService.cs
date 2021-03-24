using CongaTestAssignment.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CongaTestAssignment.Services
{
    /// <summary>
    /// Service class which has functions related to Anagram
    /// </summary>
    public class AnagramService : IAnagramService
    {
        private List<string> wordList;

        /// <summary>
        /// Constructor
        /// </summary>
        public AnagramService()
        {
            wordList = ReadWordList();
        }

        /// <summary>
        /// Method used to take input from console application and check string is anagram with WordList.txt file and return words of anagram strings.
        /// </summary>
        /// <param name="inputString">User input</param>
        /// <returns>List of string values which is anagram to input string.</returns>
        public List<string> GetAnagramStrings(string inputString)
        {
            List<string> returnList = new List<string>();

            char[] inputCharcterArray = inputString.ToLower().ToCharArray();
            Array.Sort(inputCharcterArray);
            string inputCharArray = new string(inputCharcterArray);

            wordList.ForEach(word =>
            {
                char[] charcterArray;
                charcterArray = word.ToCharArray();
                Array.Sort(charcterArray);
                string value = new string(charcterArray);

                if (inputCharArray.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    returnList.Add(word);
                }

            });

            return returnList;
        }

        /// <summary>
        /// read WordList.txt file and return lines as List of strings. 
        /// </summary>
        /// <returns></returns>
        private List<string> ReadWordList()
        {
            return System.IO.File.ReadAllLines(@$"Data\Wordlist.txt").ToList();
        }
    }
}
