
using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleStack history = new SimpleStack();

        history.Push("Move Forward");
        history.Push("Open Chest");
        history.Push("Drink Potion");

        // Test Pop
        Console.WriteLine(history.Pop());
        Console.WriteLine(history.Pop());
        Console.WriteLine(history.Pop());

        // Test the bonus methods
        Console.WriteLine();

        history.Push("Enter Cave");
        history.Push("Fight Monster");
        history.Push("Collect Treasure");

        Console.WriteLine("Top item: " + history.Peek());

        Console.WriteLine("\nCurrent Stack:");
        history.PrintStack();

        Console.WriteLine("\nIs stack empty? " + history.IsEmpty());

        // Reflection Questions

        // 1. Why does a stack return the last item added?
        // A stack uses Last In, First Out (LIFO). The last item added is at the top, so it gets removed first.

        // 2. How is a stack different from a queue?
        // A stack uses LIFO, so the last item added comes out first. A queue uses FIFO (First In, First Out), so the first item added comes out first.
    }
}
