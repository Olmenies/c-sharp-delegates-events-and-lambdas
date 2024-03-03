/*
    Explicit implementation can be used when a class implements two interfaces that have the same method signature. This way, the class can implement the method in a different way for each interface.
 */

MyClass myClass = new();
MyInterface myInterface = myClass as MyInterface; // Explicit implementation
myInterface.SomeMethod();
MyInterface myInterfaceWithoutAs = myClass; // Implicit implementation
myInterfaceWithoutAs.SomeMethod();
((MyInterface)myClass).SomeMethod(); // Explicit implementation (casting)

MyAnotherInterface myAnotherInterface = myClass as MyAnotherInterface; // Explicit implementation
myAnotherInterface.SomeMethod();
MyAnotherInterface myAnotherInterfaceWithoutAs = myClass; // Implicit implementation
myAnotherInterfaceWithoutAs.SomeMethod();
((MyAnotherInterface)myClass).SomeMethod(); // Explicit implementation (casting)

interface MyInterface
{
    void SomeMethod();
}

interface MyAnotherInterface
{
    void SomeMethod();
}

class MyClass() : MyInterface, MyAnotherInterface
{
    void MyInterface.SomeMethod()
    {
        Console.WriteLine("MyInterface.SomeMethod");
    }

    void MyAnotherInterface.SomeMethod()
    {
        Console.WriteLine("MyAnotherInterface.SomeMethod");
    }
}