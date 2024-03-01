
EventPublisher obj = new EventPublisher(); string str;
obj.valuedChangedEvent += ChangeListener;
obj.valuedChangedEvent += AnotherListener;
obj.valuedChangedEvent += delegate (object sender, MyCustomChangeEventArgs e)
{
    Console.WriteLine($"Anonymous delegate: {sender.GetType()} had the {e.Value}");

};
obj.valuedChangedEvent += (object sender, MyCustomChangeEventArgs e) => Console.WriteLine($"Lambda: {sender.GetType()} had the {e.Value}");
do
{
    Console.WriteLine("Enter a value: ");
    str = Console.ReadLine();
    if (!str.Equals("exit"))
    {
        obj.MyMessage = str;
    }
} while (!str.Equals("exit"));
Console.WriteLine("Goodbye!");

static void ChangeListener(object sender, MyCustomChangeEventArgs e)
{
    Console.WriteLine($"ChangeListener: {sender.GetType()} had the {e.Value}");
}

static void AnotherListener(object sender, MyCustomChangeEventArgs e)
{
    Console.WriteLine($"AnotherListener: {sender.GetType()}  had the  {e.Value}");
}

class MyCustomChangeEventArgs : EventArgs
{
    public string Value { get; set; }
}
class EventPublisher
{
    public event EventHandler<MyCustomChangeEventArgs> valuedChangedEvent; // 1 - Define the event signature
    private string myMessage = "";
    public string MyMessage
    {
        get { return myMessage; }
        set
        {
            myMessage = value;
            valuedChangedEvent?.Invoke(this, new MyCustomChangeEventArgs() { Value = value }); // 4 - Raise, fire, issue, trigger the event
        }
    }
}