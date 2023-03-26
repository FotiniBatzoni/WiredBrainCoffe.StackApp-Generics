

StackDoubles();
StackStrings();

Console.ReadLine();



static void StackDoubles()
{
    var stack = new SimpleStackDouble();

    stack.Push(1.2);
    stack.Push(2.8);
    stack.Push(3.2);

    double sum = 0.0;

    while (stack.Count > 0)
    {
        double item = (double)stack.Pop();
        Console.WriteLine($"Item: {item}");
        sum += item;
    }

    Console.WriteLine($"Sum: {sum}");
}

void StackStrings()
{
    var stack = new SimpleStackString();
    stack.Push("Wired Brain Coffee");
    stack.Push("Pluralsight");

    while (stack.Count > 0)
    {
        string item = (string)stack.Pop();
        Console.WriteLine($"Item: {item}");
    }
}