List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };

fruits.Add("Orange");
Console.WriteLine("Fruits List after adding:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

fruits.Remove("Banana");
Console.WriteLine("\nFruits List after removing:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
Console.WriteLine("\nFruits List:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> fruitDict = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Mango" },
    { 3, "Orange" }
};
fruitDict.Add(4, "Grapes");

Console.WriteLine("\nFruits Dictionary:");
foreach (KeyValuePair<int, string> entry in fruitDict)
{
    Console.WriteLine($"ID: {entry.Key}, Fruit: {entry.Value}");
}