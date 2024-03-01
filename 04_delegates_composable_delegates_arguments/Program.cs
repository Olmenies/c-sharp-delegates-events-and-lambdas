/*
    Delegates can be chained together to create a pipeline of methods that are executed in sequence.

    Refs added to the delegate signature are passed through the chain of delegates, so the last delegate in the chain can modify the value of the ref parameter.
 */

MyDelegate functionDelegate0 = Add;
MyDelegate functionDelegate1 = Multiply;
MyDelegate chainedDelegates = functionDelegate0 + functionDelegate1;

int a = 10;
int b = 20;

Console.WriteLine("Calling first delegate");
functionDelegate0(a, ref b);

Console.WriteLine("\nCalling second delegate");
functionDelegate1(a, ref b);

Console.WriteLine("\nCalling chained delegates");
chainedDelegates(a, ref b);

Console.WriteLine("\nRemoved first delegate");
chainedDelegates -= functionDelegate0;
chainedDelegates(b, ref b);

#region Functions to be used as delegates
void Add(int arg0, ref int arg1)
{
    Console.WriteLine("Add is being executed");
    arg1 += 20;
    Console.WriteLine("Number of Add is: " + (arg0 + arg1).ToString());
}

void Multiply(int arg0, ref int arg1)
{
    Console.WriteLine("Multiply is being executed");
    Console.WriteLine("Number of Multiply is: " + (arg0 * arg1).ToString());
}
#endregion

public delegate void MyDelegate(int arg0, ref int arg1);