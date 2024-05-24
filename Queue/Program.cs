Queue<int> ints = new();

ints.Enqueue(10);
ints.Enqueue(320);
ints.Enqueue(20);
ints.Enqueue(100);

Console.WriteLine("Foreach loop:\n");
foreach (int number in ints)
{
    Console.WriteLine(number);
}

Console.ReadKey();
Console.Clear();

Console.WriteLine("Dequeue:\n");
Console.WriteLine(ints.Dequeue());
Console.WriteLine(ints.Dequeue());
Console.WriteLine(ints.Dequeue());
Console.WriteLine(ints.Dequeue());

Console.ReadKey();
Console.Clear();

Console.WriteLine("Is queue empty? "+ (ints.Count == 0));

Console.ReadKey();