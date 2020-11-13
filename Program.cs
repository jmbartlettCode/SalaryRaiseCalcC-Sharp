/* 
Josh Bartlett
29June2019
Assignment 2.2
Prompt user for and accepts an employee's salary and 
calculates a 4% increase and displays with explanatory text. 
*/

using System;
using static System.Console;

namespace ProjectRaises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare constant for the 4% increase
            const double increase = .04;

            // Declare string variable to hold the user input
            string salaryString;

            // Declare double variables to hold converted user input,
            // the amount of increase, and next year's salary
            double salaryDouble;
            double salaryIncrease;
            double nextYearSalary;
            
            // Prompt for user input and store the input into the string variable
            Write("Enter Salary: $");
            salaryString = ReadLine();

            // Convert string to double and store that value in double variable
            salaryDouble = Convert.ToDouble(salaryString);

            // Calculations to get the amount of increase and next year's salary 
            salaryIncrease = salaryDouble * increase;
            nextYearSalary = salaryDouble + salaryIncrease;

            // Displays the current salary, the rounded amount of increase, and 
            // next year's salary rounded
            WriteLine("The current salary of ${0} will increase by ${1} (4%), bringing next years salary to ${2}.", salaryDouble, Math.Round(salaryIncrease, 2), Math.Round(nextYearSalary, 2));

            // Keeps console open unitl a key is pressed
            Write("Press any key to close...");
            ReadKey(true);            
        }
    }
}
