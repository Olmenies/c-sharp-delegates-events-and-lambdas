// Delegates can be seen as a type-safe function pointer. They are used to pass methods as arguments to other methods.
// Also can be seen as placeholders for methods, which can be assigned at runtime. --> Vars that can point to methods
MyDelegate functionDelegate;

functionDelegate = Add;
Console.WriteLine("functionDelegate is add: " + functionDelegate(10, 20));

functionDelegate = Multiply;
Console.WriteLine("functionDelegate is multiply: " + functionDelegate(10, 20));

MyClass myClass = new();
functionDelegate = myClass.instanceMethod;
Console.WriteLine("functionDelegate is instanceMethod: " + functionDelegate(10, 20));

#region Functions that implements the delegate
static string Add(int a, int b)
{
    Console.WriteLine("Add is being executed");
    return (a + b).ToString();
}

static string Multiply(int a, int b)
{
    Console.WriteLine("Multiply is being executed");
    return (a * b).ToString();
}

class MyClass
{
    //Delegates can be bound to instance members as well as static class functions
    public string instanceMethod(int arg0, int arg1)
    {
        Console.WriteLine("instanceMethod is being executed");
        return ((arg0 + arg1) * arg1).ToString();
    }
}
#endregion

delegate string MyDelegate(int arg0, int arg1);