/*
    - Dictionaries give a way to store key-value pairs. -> One-to-one matching
    - The key is used to look up the value
    - The key must be unique
 */

Dictionary<string, string> fileTypes = [];

fileTypes.Add("mp3", "Music file");
fileTypes.Add("txt", "Text file");
fileTypes.Add("jpg", "Image file");
fileTypes.Add("pdf", "PDF file");
Console.WriteLine($"Amout key-value pairs: {fileTypes.Count}");
try
{
    fileTypes.Add("mp3", "value does't need to match");
}
catch (ArgumentException exception)
{
    Console.WriteLine($"Key already exists: {exception.Message}");
}

Console.WriteLine("------ Removing pdf ------");
fileTypes.Remove("pdf");

Console.WriteLine("------ Changing mp3 value ------");
fileTypes["mp3"] = "Audio file";
Console.WriteLine("New mp3 description: {0}", fileTypes["mp3"]);

Console.WriteLine("------ Iterating ------");
foreach (KeyValuePair<string, string> fileType in fileTypes)
{
    Console.WriteLine($"Extension (key): {fileType.Key}, Description (value): {fileType.Value}");
}