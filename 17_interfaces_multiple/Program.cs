Document document = new("Cumbia");
if ((document is IStorable) && (document is IEncryptable))
{
    Console.WriteLine("Document is storable & encryptable");
    document.Save();
    document.Load();
    document.Encrypt();
    document.Decrypt();
}


interface IStorable
{
    void Save();
    void Load();
    bool NeedsSave { get; set; }
}

interface IEncryptable
{
    void Encrypt();
    void Decrypt();
    bool IsEncrypted { get; set; }
}

class Document : IStorable, IEncryptable
{
    public string Name { get; set; }
    public bool NeedsSave { get; set; }
    public bool IsEncrypted { get; set; }

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

    public void Encrypt()
    {
        Console.WriteLine("Encrypt");
    }

    public void Decrypt()
    {
        Console.WriteLine("Decrypt");
    }
}