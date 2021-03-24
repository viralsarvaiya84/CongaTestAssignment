using CongaTestAssignment.Services;
using CongaTestAssignment.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CongaTestAssignment
{
    /// <summary>
    /// main program file of console application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// main method of console application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Dependancy Injection
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IAnagramService, AnagramService>()
                .BuildServiceProvider();

            // Take Input from the User
            Console.Write("Please Enter the word : ");
            
            string userInput = string.Empty;
            userInput = Console.ReadLine();

            Console.Write("You have entered: " + userInput);

            Console.Write("List of Anagrams words for "+ userInput + " from WordList Files are as below, " + Environment.NewLine);

            var anagramService = serviceProvider.GetService<IAnagramService>();

            var outputList = anagramService.GetAnagramStrings(userInput);

            outputList.ForEach(x => Console.WriteLine(x));
        }

    }
}
