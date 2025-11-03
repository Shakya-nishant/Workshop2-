int[] fav = { 9, 5, 7, 3, 4 };
Array.Sort(fav);
Console.WriteLine("Sort");
foreach (int a in fav)
    Console.WriteLine(a);

Array.Reverse(fav);
Console.WriteLine("\nreversed");
foreach (int a in fav)
    Console.WriteLine(a);

Console.WriteLine("\nArray:");
for (int idx = 0; idx < fav.Length; idx++)
{
    Console.WriteLine($"[{idx}] = {fav[idx]}");
    }

int index = Array.IndexOf(fav, 7);
Console.WriteLine($"\nIndex of 7 = {index}");