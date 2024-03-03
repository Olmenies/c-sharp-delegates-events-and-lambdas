/*
    Differences between intefraces and classes:
- Classes work as templates for objects, defining their structure and behavior.
- Interfaces are contracts that defines behavior. They're used to tell other class that a certain class can do something.
- The class HAS to implement the interface's methods.
- While you could create a base class that implements the desired behavior, an interface could make that objects not related to that base class could also implement that behavior.
- Interfaces are designed to expose functionalities to other classes, that's why they're public by default.
- As instances aint' classes, they cant be instantiated.
 */

Document document = new("Cumbia");
document.Save();
document.Load();

interface IStorable
{
    void Save();
    void Load();
    bool NeedsSave { get; set; }
}

class Document : IStorable
{
    public string Name { get; set; }
    public bool NeedsSave { get; set; }

    public Document(string name)
    {
        Name = name;
        Console.WriteLine($"Document name: {name}");
    }

    public void Save()
    {
        Console.WriteLine("Save");
    }

    public void Load()
    {
        Console.WriteLine("Load");
    }
}