MyClass obj = new();

obj.ValueChangedEvent += (value) => Console.WriteLine($"The value changed to {value}");

string str;
do
{
    str = Console.ReadLine();
    if (!str.Equals("exit"))
    {
        obj.Message = str;
    }
} while (!str.Equals("exit"));

Console.WriteLine("Goodbye!");

delegate void MyEventHandler(string value);

class MyClass
{
    private string message;
    public event MyEventHandler ValueChangedEvent;

    public string Message
    {
        get { return message; }
        set
        {
            message = value;
            ValueChangedEvent?.Invoke(value);
        }
    }
}