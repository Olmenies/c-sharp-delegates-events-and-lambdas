/*
    Delegates can be chained together to create a pipeline of methods that are executed in sequence.

    Things to keep in mind:
    - Unhandled exceptions will stop the execution of the pipeline.
    - The return value of the first method is passed as an argument to the second method, and so on.
    - The return value of the last method is the return value of the entire pipeline.
 */

MyDelegate functionDelegate0 = Add;
MyDelegate functionDelegate1 = Multiply;
MyDelegate chainedDelegates = functionDelegate0 + functionDelegate1;

int a = 10;
int b = 20;

Console.WriteLine("Calling first delegate");
functionDelegate0(a, b);

Console.WriteLine("\nCalling second delegate");
functionDelegate1(a, b);

Console.WriteLine("\nCalling chained delegates");
chainedDelegates(a, b);

Console.WriteLine("\nRemoved first delegate");
chainedDelegates -= functionDelegate0;
chainedDelegates(b, b);

void Add(int arg0, int arg1)
{
    Console.WriteLine("Add is being executed");
    Console.WriteLine("Number of Add is: " + (arg0 + arg1).ToString());
}

void Multiply(int arg0, int arg1)
{
    Console.WriteLine("Multiply is being executed");
    Console.WriteLine("Number of Multiply is: " + (arg0 * arg1).ToString());
}

public delegate void MyDelegate(int arg0, int arg1);