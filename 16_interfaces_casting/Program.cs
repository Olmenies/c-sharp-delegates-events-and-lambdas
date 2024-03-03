/*
    Is: Can be used to determine if an object is an instance of deterimed class or interface. -> Just boolean test
    As: Used to cast an object to a different type. -> Can throw an exception if the cast is invalid

Both are very useful when working with collections of objects, as you can check if an object is of a certain type and then cast it to that type to use its methods and properties.
 */


Document document = new("Cumbia");
if (document is IStorable)
{
    Console.WriteLine("Document is storable");
    document.Save();
    document.Load();
}

IStorable storable = document as IStorable;
if (storable != null)
{
    Console.WriteLine("storable is not null");
    storable.Save();
    storable.Load();
}

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