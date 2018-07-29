using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// class MainProgram
    /// The MainProgram class is the Start of the TemperatureConverter application
    /// and includes the Main method which is the entry point of the program.
    /// </summary>
    class MainProgram
    {
        /// <summary>
        /// method Main
        /// The Main method is the entry point for the program
        /// The user console is arranged for cosmetic effects
        /// This simple method declares and instantiates a TemperatureConverter object
        /// The rest of the program then runs through the Start method of the object
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Arrange the Console Window
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "Temperature Converter";
            
            // Declare and instantiate a TemperatureConverter object
            TemperatureConverter myTemperatures = new TemperatureConverter();

            // Run the Start method in the TemperatureConverter object
            myTemperatures.Start();

            // Print out Exit Message to User
            Console.WriteLine("Press Enter to Exit Console Window");

            // Wait for the User Input
            Console.ReadLine();
        } // End of Main
    } // End of MainProgram
}
