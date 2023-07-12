using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 03 (I)
            // Example using TryParse method to convert string to int
            //string intString = "567";
            //int intValue;
            //if (int.TryParse(intString, out intValue))
            //{
            //    Console.WriteLine("TryParse successful. Converted integer value: " + intValue);
            //}
            //else
            //{
            // Console.WriteLine("TryParse failed. Invalid input string.");
            //}


            //Assignment 03 (II)
            // Example using Convert method to convert string to double
            //string doubleString = "3.14";
            //try
            //{
            //    double doubleValue = Convert.ToDouble(doubleString);
            //    Console.WriteLine("Convert successful. Converted double value: " + doubleValue);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Convert failed. Invalid input format.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Convert failed. Input value is too large or too small.");
            //}

            //Assignment 03 (III)
            // Example using Parse method to convert string to decimal
            //string decimalString = "25.46";
            //try
            //{
            //    decimal decimalValue = decimal.Parse(decimalString);
            //    Console.WriteLine("Parse successful. Converted decimal value: " + decimalValue);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Parse failed. Invalid input format.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Parse failed. Input value is too large or too small.");



            //Assignment 03-(Part 02)
            // Convert a string to an integer using TryParse
            

            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                int result = number * 5;
                Console.WriteLine($"The result is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Convert a string to a DateTime object using Convert
            Console.WriteLine("Enter a date (dd/mm/yyyy): ");
            string dateInput = Console.ReadLine();
            try
            {
                DateTime date = Convert.ToDateTime(dateInput);
                DateTime newDate = date.AddMonths(-1);
                Console.WriteLine($"One month ago was: {newDate.ToShortDateString()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid date in the format dd/mm/yyyy.");
            }

            // Convert a string to a TimeSpan object using Parse
            Console.WriteLine("Enter a time (hh:mm:ss): ");
            string timeInput = Console.ReadLine();
            try
            {
                TimeSpan time = TimeSpan.Parse(timeInput);
                TimeSpan newTime = time.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine($"Two hours later will be: {newTime.ToString()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid time in the format hh:mm:ss.");
            }
        }
    }
    
}
