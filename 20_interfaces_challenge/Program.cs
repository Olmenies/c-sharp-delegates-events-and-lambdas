/*
    - Ask a number to user
    - Genenerate a random number between0 and the number given by the user
    - When the user insert something different than a number, the program should show an error message
    - If the user types "quit", the program should end
    - Implement the IRandomizable interface
    - IRandobizamle should contain a method GetRandomNumber which takes one parameter and returns an integer
 */

MyClass myClass = new();

string input;
do
{
    Console.WriteLine("Enter a number: ");
    input = Console.ReadLine();
    if (int.TryParse(input, out int number))
    {
        Console.WriteLine($"Random number: {myClass.GetRandomNumber(number)}");
    }
    else if (input != "exit")
    {
        Console.WriteLine("Invalid input");
    }
} while (input != "exit");

interface IRandomizable
{
    int GetRandomNumber(int number);
}

class MyClass : IRandomizable
{
    public int GetRandomNumber(int number)
    {
        Random random = new();
        return random.Next(0, number);
    }
}
