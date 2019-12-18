using System;

namespace Ho.Scratch.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string addressOne = "myOne";
            string addressTwo = "myTwo";
            string addressThree = "myThree";
            string addressFour = "myFour";
            string fullAddress = AppendNonNullStrings(addressOne, addressTwo, addressThree, addressFour);
            Console.WriteLine(fullAddress);
            addressTwo = null;
            addressThree = null;
            fullAddress = AppendNonNullStrings(addressOne, addressTwo, addressThree, addressFour);
            Console.WriteLine(fullAddress);
        }

        private static string AppendNonNullStrings(params string[] strings)
        {
            string fullString = "";
            foreach (string input in strings)
            {
                fullString += (String.IsNullOrEmpty(input) ? "" : $"{ input } ");
            }
            return fullString;
        }
    }
}
