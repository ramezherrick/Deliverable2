using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net.Http;

namespace Deliverable_2
{
    class Program
    {
        internal static int lettertonumber(char letter)
        {
            int index = char.ToUpper(letter) - 64;
            return index;
        }
        public static void Main(string[] args)
        {
            int checksum = 0; string message = "";
            Console.Write("What is your message?");
            string input = Console.ReadLine();

            // Creates a TextInfo based on the "en-US" culture.
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            // Changes a string to uppercase.
            input = myTI.ToUpper(input);

            for (int i = 1; i <= input.Length; i++)
            {
             //convert to ascii
                int ascii = (int)Convert.ToChar(input[i-1]);
                checksum += ascii;
               
                int v = lettertonumber(input[i-1]);
                message += v + "-";
             

            }
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);


        }
    }
}
