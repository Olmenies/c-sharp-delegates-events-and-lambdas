/*
    IComparable, IComparer -> Used to compare objects of the same type -> Sorting
    IDisposable -> Used to safely dispose objects and release resources
    IEquatable -> Used to determine equality of twe objects of the same type
    INotifyPropertyChanged -> Used to notify when a property changes -> Provdies a PropertyChanged event
 */


using System.ComponentModel;

Document document = new("Cumbia");
document.PropertyChanged += (sender, e) => Console.WriteLine($"Property changed! {e.PropertyName}");

document.Name = "Peposa";
document.NeedsSave = true;

interface IStorable
{
    void Save();
    void Load();
    bool NeedsSave { get; set; }
}

class Document : IStorable, INotifyPropertyChanged
{

    private string name = "";
    public string Name
    {
        get { return name; }
        set
        {
            name = value;
            OnPropertyChanged($"Name: {name}");
        }
    }
    public bool needsSave;
    public bool NeedsSave
    {
        get { return needsSave; }
        set
        {
            needsSave = value;
            OnPropertyChanged($"NeedsSave!:{value}");
        }
    }
    public event PropertyChangedEventHandler? PropertyChanged;

    public Document(string name)
    {
        Name = name;
        Console.WriteLine($"Document name: {name}");
    }

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); //These args come from the Interface
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