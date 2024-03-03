/*
 */

Console.WriteLine("------ Stack methods ------");
Stack<string> sportsStack = [];
sportsStack.Push("Soccer");
sportsStack.Push("Basketball");
sportsStack.Push("Tennis");
sportsStack.Push("Golf");
Console.WriteLine($"Amount of sports in stack: {sportsStack.Count}");
Console.WriteLine($"Next sport to pop (top item): {sportsStack.Peek()}");
Console.WriteLine($"Popping {sportsStack.Pop()}");
Console.WriteLine($"Next sport to pop (top item): {sportsStack.Peek()}");
Console.WriteLine($"StackContains Tennis: {sportsStack.Contains("Tennis")}");

Console.WriteLine("------ Queues methods ------");
Queue<string> sportsQueue = [];
sportsQueue.Enqueue("Soccer");
sportsQueue.Enqueue("Basketball");
sportsQueue.Enqueue("Tennis");
sportsQueue.Enqueue("Golf");
Console.WriteLine($"Amount of sports in queue: {sportsQueue.Count}");
Console.WriteLine($"Next sport to dequeue (first item): {sportsQueue.Peek()}");
Console.WriteLine($"Dequeueing {sportsQueue.Dequeue()}");
Console.WriteLine($"Next sport to dequeue (first item): {sportsQueue.Peek()}");
Console.WriteLine($"QueueContains Tennis: {sportsQueue.Contains("Tennis")}");