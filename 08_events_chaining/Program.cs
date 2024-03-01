
EventPublisher obj = new EventPublisher(); string str;
obj.valuedChangedEvent += ChangeListener;
obj.valuedChangedEvent += AnotherListener;
obj.valuedChangedEvent += delegate (string value)
{
    Console.WriteLine($"Anonymous delegate: The value has been changed to {value}");

};
obj.valuedChangedEvent += (value) => Console.WriteLine($"Lambda function: The value has been changed to {value}");
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

static void ChangeListener(string value)
{
    Console.WriteLine($"The value has been changed to {value}");
}

static void AnotherListener(string value)
{
    Console.WriteLine($"Another listener: The value has been changed to {value}");
}

delegate void MyCustomEventHandler(string value); // 0 - Custom EventHandler
class EventPublisher
{
    public event MyCustomEventHandler valuedChangedEvent; // 1 - Define the event signature
    private string myMessage = "";
    public string MyMessage
    {
        get { return myMessage; }
        set
        {
            myMessage = value;
            valuedChangedEvent?.Invoke(value); // 4 - Raise, fire, issue, trigger the event
        }
    }
}