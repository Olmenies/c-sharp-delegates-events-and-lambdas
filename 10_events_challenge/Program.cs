/*
    Use events to watch changes on an object and respond to those changes
 */

PiggyBank piggyBank = new();
piggyBank.OnBalanceChanged += (sender, e) => Console.WriteLine($"Balance changed to {e.Balance}");
piggyBank.OnPiggyFull += (sender, e) => Console.WriteLine("Piggy is full!");

do
{
    Console.WriteLine("Enter the amount to change the balance by:");
    var input = Console.ReadLine();
    if (int.TryParse(input, out int amount))
        piggyBank.ChangeBalance(amount);
    else
        Console.WriteLine("Invalid input");
} while (true);



class MyEventArgs(int balance) : EventArgs
{
    public int Balance { get; set; } = balance;
}
class PiggyBank
{
    public int PiggyCapacity { get; } = 500;
    public int Balance { get; private set; } = 0;
    public event EventHandler<MyEventArgs>? OnBalanceChanged;
    public event EventHandler? OnPiggyFull;

    public void ChangeBalance(int amount)
    {
        if (Balance + amount > PiggyCapacity)
            OnPiggyFull?.Invoke(this, EventArgs.Empty);
        else
        {
            Balance += amount;
            OnBalanceChanged?.Invoke(this, new MyEventArgs(Balance));
        }

    }
}