using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// class TemperatureConverter
    /// This class is the blueprint for the TemperatureConverter
    /// Has no instance fields
    /// Start method does all the main work, actions
    /// Encapsulated except for the Start method
    /// TemperatureConverter will allow the user to select their
    /// choice to calculate and display conversion tables either 
    /// 1.) Convert Fahrenheit to Celsius
    /// 2.) Convert Celsius to Fahrenheit or 
    /// 0.) Exit the Converter
    /// </summary>
    class TemperatureConverter
    {
        /// <summary>
        /// method Start()
        /// This method is the entry point of the class and the main
        /// sequential actions. It will display a user menu, gather user
        /// input choice (a number), and control flow of the program based on
        /// that user choice. 
        /// </summary>
        public void Start()
        {
            int choice = 0; //user choice

            do
            {
                // Display the User Choice Menu
                DisplayMenu();

                // Gather User Input
                choice = Input.ReadIntegerConsole("Your Choice: ");

                // Match to Choice
                switch (choice)
                {
                    case 1:
                        CalculateFahrenheitToCelsius(); 
                        break;
                    case 2:
                        CalculateCelsiusToFahrenheit();
                        break;
                    case 0: // do nothing exit the loop
                        break;
                    default:
                        Console.WriteLine("Invalid Option: Choose 0, 1, or 2 Thank you ");
                        break;
                }
            } while (choice != 0);     
        } // End of Start

        //        Quiz:
        //1. Why the declaration of the variable choice does not contain the modifier private before
        //the type int?
        // My Answer: This variable is local to the Start method scope and inacessible
        // outside the class
        //2. Can the do-while statement in above code be replaced by a while-statement?
        // My Answer: Yes, you would set the int choice=-1 and then while(choice !=0) {}

        /// <summary>
        /// method CalculateCelsiusToFahrenheit()
        /// This method converts Celsius to Fahrenheit from values
        /// 0 through 100 but iterates by 5 units apart 
        /// The method calls a helper method to convert the value
        /// and displays the unit and the converted unit in columns of 3
        /// </summary>
        private void CalculateCelsiusToFahrenheit()
        {
            double convertedValue = 0;      // holds the converted value
            string textOut = string.Empty;  // for the output on the display
            int count = 0;                  // counter for the 3-column output

            // The Main iteration to make units of Celsius
            // For each iteration, the unit is converted to Fahrenheit
            // The Text is written in a formatted string to the Console
            // but in 3-column format
            for (int i = 0; i <= 100; i+=5)
            {
                // Increment the counter for columns
                count++; 

                // Convert the Celsius unit to Fahrenheit
                convertedValue = CelsiusToFahrenheit(i);

                // Format the output string to the Console Window
                textOut = string.Format("{0,16:f2} C = {1,6:f2} F",i, convertedValue);

                // Print to the Console Window but not a new line character
                Console.Write(textOut);

                // Check the column count variable
                // Reset if on the third column and print a new line
                if (count == 3)
                {
                    count = 0;
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

        } // End of CalculateCelsiusToFahrenheit

        /// <summary>
        /// method CalculateFahrenheitToCelsius()
        /// This method creates fahrenheit units and calculates the
        /// values in Celsius and displays them on the console window
        /// in a formated string and 3 columns
        /// </summary>
        private void CalculateFahrenheitToCelsius()
        {
            double convertedValue = 0;      // this holds the converted unit value
            string textOut = string.Empty;  // this is for the format string
            int count = 0;                  // this is used for the column format count

            // This iteration creates and iterates over 212 units but by every 4th unit
            // calculates the unit in Celsius, displays in a formated string, and prints
            // out to the console window in 3-columns format
            for (int i = 0; i <= 212; i += 4)
            {
                // Increment the counter for columns
                count++; 

                // Convert the unit to Celsius
                convertedValue = FahrenheitToCelsius(i);

                // Create a formated string to display the unit and converted value
                textOut = string.Format("{0,16:f2} F = {1,6:f2} C", i, convertedValue);
                
                // Print the formated string to the Console Window
                Console.Write(textOut);

                // This keeps track and checks the count for the column format
                // if at 3, a new line is entered and the counter is reset
                if (count == 3)
                {
                    count = 0;
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        } // End of CalculateFahrenheitToCelsius

        /// <summary>
        /// method CelsiusToFahrenheit(double celsius)
        /// This method takes a double value and returns a double value
        /// The input parameter is the celsius unit and the output value is
        /// the fahrenheit value
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        private double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5.0) * celsius + 32;
            return fahrenheit;
        } // End of CelsiusToFahrenheit

        /// <summary>
        /// method FahrenheitToCelsius(double fahrenheit)
        /// This method takes a double value and returns a double value
        /// The input parameter is the fahrenheit unit and the output value is
        /// the celsius value
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        private double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9.0) * (fahrenheit - 32);
            return celsius;
        } // End of FahrenheitToCelsius

        /// <summary>
        /// method DisplayMenu()
        /// This method displays the main user menu to the console window
        /// </summary>
        private void DisplayMenu()
        {
            Console.WriteLine("______________________________________");
            Console.WriteLine("|------------Main Menu---------------|");
            Console.WriteLine("|____________________________________|");
            Console.WriteLine("| Convert Fahrenheit to Celsius:...1 |");
            Console.WriteLine("| Convert Celsius to Fahrenheit:...2 |");
            Console.WriteLine("| Exit the Converter:..............0 |");
            Console.WriteLine("|____________________________________|");
        } // End of DisplayMenu
    } // End of TemperatureConverter
} // End of TemperatureConverter
