MyDelegate functionDelegate = (int a) => a * a;
Console.WriteLine($"functionDelegate a*a: {functionDelegate(2)}");
functionDelegate = (int a) => a * 10;
Console.WriteLine($"functionDelegate a*2: {functionDelegate(2)}");


MyVoidDelegate voidDelegate = (int a, string prefix) => Console.WriteLine($"{prefix} {a}:" + a * 10);
voidDelegate(2, "voidDelegate (2 args) the number a*10:");

MyBoolDelegate boolDelegate = (int a) => a > 10;
Console.WriteLine($"boolDelegate a>10: {boolDelegate(2)}");

delegate int MyDelegate(int x);
delegate void MyVoidDelegate(int x, string prefix);
delegate bool MyBoolDelegate(int x);