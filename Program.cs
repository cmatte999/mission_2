using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        int[] results = DiceRoller.RollDice(numberOfRolls);

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1 roll.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

        for (int i = 0; i < results.Length; i++)
        {
            Console.Write($"{i + 2}: ");
            Console.WriteLine(new String('*', results[i]));
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}

public class DiceRoller
{
    public static int[] RollDice(int numberOfRolls)
    {
        int[] results = new int[11]; // Array to store results for sums 2-12

        Random random = new Random();
        for (int i = 0; i < numberOfRolls; i++)
        {
            int roll = random.Next(1, 7) + random.Next(1, 7); // Simulate rolling two dice
            results[roll - 2]++; // Increment the count for the rolled sum
        }

        return results;
    }
}
