// Instead of writing a named method and then passing it to the delegate, you can use an anonymous method if it increases readability.

MyDelegate functionDelegate = delegate (int a, int b)
{
    Console.WriteLine("Anonymous method is being executed");
    return (a + b).ToString();
};
Console.WriteLine("functionDelegate is anonymous method: " + functionDelegate(10, 20));

functionDelegate = delegate (int a, int b)
{
    Console.WriteLine("Anonymous method is being executed");
    return (a * b).ToString();
};
Console.WriteLine("functionDelegate is anonymous method: " + functionDelegate(10, 20));


delegate string MyDelegate(int arg0, int arg1);