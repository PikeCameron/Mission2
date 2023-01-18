using System;

class Dice
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
        int numRolls = int.Parse(Console.ReadLine());

        // array to keep track of the number of times each total number is thrown
        int[] rolls = new int[13];

        Random rnd = new Random();
        for (int i = 0; i < numRolls; i++)
        {
            // roll dice 1 and 2
            int roll1 = rnd.Next(1, 7); 
            int roll2 = rnd.Next(1, 7);
            int total = roll1 + roll2;
            rolls[total]++;
        }

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls + ".");


        // print the numbers with the appropriate amount of asterisks
        for (int i = 2; i <= 12; i++)
        {
            Console.Write(i + ": ");
            int percent = (int)((double)rolls[i] / numRolls * 100);
            for (int j = 0; j < percent; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}
