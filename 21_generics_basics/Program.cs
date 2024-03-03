/*
    Generics provide a way of using data structures such as collections in a type-safe way. This means that you can create a collection that only accepts a certain type of object, and the compiler will enforce this rule.
 */


// Arraylists are old, you're not supposed to use them anymore

int total = 0;

List<int> myList = [];

myList.Add(1);
myList.Add(2);
myList.Add(3);
myList.Add(4);
//myList.Add("5"); As the list is of type int, this line would throw an error

foreach (var item in myList)
{
    total += item;
}

Console.WriteLine(total);



