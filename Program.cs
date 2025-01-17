// Benson Kim

//    ask user for how many rolls do they want
//    record number

//    for the amount of rolls

//    roll 1 die and store number

//    roll another die and store number

//    add two numbers together and update the tally

//    for each number

//    print the number

//    calculate the percentage the number was rolled

//    for each percentage, display the asterisk
using System;

namespace DiceRollingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for the number of rolls
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            if (!int.TryParse(Console.ReadLine(), out int numberOfRolls) || numberOfRolls <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                // this just makes sure that the number is a positive integer. 
                return;
            }

            // tally up value
            // tally is what we name the array
            int[] tally = new int[13]; // Only indices 2 through 12 will be used

            Random random = new Random();

            // Roll dice amount user choose
            for (int i = 0; i < numberOfRolls; i++)
            {
                int die1 = random.Next(1, 7); // Roll first die (1-6)
                int die2 = random.Next(1, 7); // Roll second die (1-6)
                int sum = die1 + die2;        // Add two numbers
                tally[sum]++;                // Update the tally for the sum
            }

            // show results
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

            for (int i = 2; i <= 12; i++)
            {
                // so we loop through each tally and convert it into a percentage
                // Calculate the percentage of rolls for this sum
                int percentage = (int)Math.Round((tally[i] / (double)numberOfRolls) * 100);

                // Print the number, percentage, and histogram
                Console.WriteLine($"{i}: {new string('*', percentage)}");
            }

            // End message
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
