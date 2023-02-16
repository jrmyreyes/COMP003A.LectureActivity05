/*
 * Author: Ron Jeremy Reyes
 * Course: COMP-003A
 * Purpose: Lecture Activity for week 5
 * 
 */
using System.Security.Cryptography.X509Certificates;

namespace COMP003A.LectureActivity05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Methods & XML Comments");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("\n");

            HelloWorld();
            HelloWorld("Grace Hopper");
            HelloWorld("Donald Knuth");
            HelloWorld("Alan Turing", DateTime.Now.Year - 1912);
            HelloWorld("Ada Lovelace", DateTime.Now.Year - 1815);
            HelloWorld("Charles Babbage", DateTime.Now.Year - 1791);

            Console.WriteLine("\n");
            Console.Write("Enter value for inputNumber1: ");
            decimal inputNumber1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter value for inputNumber2: ");
            decimal inputNumber2 = Convert.ToDecimal(Console.ReadLine());

            // call to Sum
            decimal sum = Add(inputNumber1, inputNumber2);
            Console.WriteLine($"Summation: {sum}");

            // simplified method
            Console.WriteLine($"Subtraction: {Substract(inputNumber1, inputNumber2)}");
            Console.WriteLine($"Multiplication: {Multiply(inputNumber1, inputNumber2)}");
            Console.WriteLine($"Division: {Divide(inputNumber1, inputNumber2)}");
            Console.WriteLine($"Remainder: {Remainder(inputNumber1, inputNumber2)}");

            // recursion
            Console.WriteLine("\n");
            Inception("This is inception level ", 5);
        }

        /// <summary> 
        /// Method without parameters and return value
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Method overloading with one parameter but no return value
        /// Method overloading => same method name but different signature (different paramameters)
        /// </summary>
        /// <param name="inputName">String input</param>
        static void HelloWorld(string inputName)
        {
            Console.WriteLine($"Hello, {inputName}");
        }

        /// <summary>
        /// Method overloading with multiple parameters but no return value
        /// </summary>
        /// <param name="inputName">String input</param>
        /// <param name="inputAge">Integer Ouput</param>
        static void HelloWorld(string inputName, int inputAge)
        {
            Console.WriteLine($"Hello, {inputName}, age {inputAge}");
        }

        /// <summary>
        /// Method  for adding two numeric variables
        /// </summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2">Decimal input</param>
        /// <returns>Sum of two deciaml inputs</returns>
        static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Method for substracting two numeric variables
        /// </summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2">Decimal input</param>
        /// <returns>Difference of two decimal inputs</returns>
        static decimal Substract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// Method for multiplying two numeric variables
        /// </summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2">Decimal input</param>
        /// <returns>Product of two decimal inputs</returns>
        static decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Method for dividing two numeric variables
        /// </summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2">Decimal input</param>
        /// <returns>Quotient of two decimal inputs</returns>
        static decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// Method for getting the remainder after dividing two numeric variables
        /// </summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2">Decimal input</param>
        /// <returns>Remainder after dividing two decimal inputs</returns>
        static decimal Remainder(decimal  num1, decimal num2)
        {
            return num1 % num2;
        }

        /// <summary>
        /// Recursive Method
        /// </summary>
        /// <param name="message">String input to print to console</param>
        /// <param name="counter">Integer input used as a looping counter</param>
        static void Inception(string message, int counter)
        {
            Console.WriteLine($"{message} {counter}");
            counter--;
            if (counter >= 0) Inception(message, counter);
        }
    }
}