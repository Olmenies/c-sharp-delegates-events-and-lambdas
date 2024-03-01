/*
 Events are specialized delegates that are used to notify the subscribers when something happens.
 */

EventPublisher obj = new EventPublisher(); string str;

/****** BELOW YOU'LL FIND 3 DIFFERENT WAYS OF HANDLING EVENTS ******/
// Same, with a method -> Method serves as event handler
obj.valuedChangedEvent += EventHandler; // 2 - Subscribe to the event 3 - Define the event handler IN THIS CASE, IS A METHOD

// Same, with anonymous delegate
obj.valuedChangedEvent += delegate (string value) { Console.WriteLine($"The value has been changed to {value}"); }; // 2 - Subscribe to the event 3 - Define the event handler IN THIS CASE, IS AN ANONYMOUS DELEGATE

obj.valuedChangedEvent += (value) => Console.WriteLine($"The value has been changed to {value}"); // 2 - Subscribe to the event 3 - Define the event handler IN THIS CASE, IS A LAMBDA FUNCTION

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

static void EventHandler(string value)
{
    Console.WriteLine($"The value has been changed to {value}");
}

// 0 - We define the signature of the event
delegate void MyEventHandler(string value); // Custom EventHandler
class EventPublisher
{
    public event MyEventHandler valuedChangedEvent; // 1 - Define the event signature

    private string myMessage = "";
    public string MyMessage
    {
        get { return myMessage; }
        set
        {
            myMessage = value;
            valuedChangedEvent?.Invoke(value); // 4 - Raise the event
        }
    }
}
