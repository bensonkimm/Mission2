internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice rolling Simulator!");
        Console.WriteLine("How many dice do you want to roll? ");

        if (!int.TryParse(Console.ReadLine(), out int numberofRolls) || numberofRolls <= 0)
            Console.WriteLine("Invalid input. Please a positive integer.");
        return;
    }
}