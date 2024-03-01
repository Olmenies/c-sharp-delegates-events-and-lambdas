/*
 Lamda functions are short hand way of writting anynomous functions and, because they're base on delegates, they can be used to pass methods as arguments to other methods.
 */

// Expression lambda
MyDelegate functionDelegate = (int a, int b) => a + b;
Console.WriteLine("functionDelegate is add: " + functionDelegate(10, 20));

// Statement lambda
functionDelegate = (int a, int b) =>
{
    Function();
    AnotherFunction();
    return a * b;
};
Console.WriteLine("functionDelegate is multiply: " + functionDelegate(10, 20));


void Function()
{
    Console.WriteLine("I'm function");
}

void AnotherFunction()
{
    Console.WriteLine("I'm another function");
}

public delegate int MyDelegate(int a, int b);
