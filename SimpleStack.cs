class SimpleStack
{
    private string[] items = new string[10];
    private int count = 0;

    // Add an item to the top of the stack
    public void Push(string item)
    {
        if (count < items.Length)
        {
            items[count] = item;
            count++;
        }
        else
        {
            Console.WriteLine("Stack is full.");
        }
    }

    // Remove and return the top item
    public string Pop()
    {
        if (IsEmpty())
        {
            return "Stack is empty.";
        }

        count--;
        string item = items[count];
        items[count] = null!;

        return item;
    }

    // Look at the top item without removing it
    public string Peek()
    {
        if (IsEmpty())
        {
            return "Stack is empty.";
        }

        return items[count - 1];
    }

    // Check whether the stack is empty
    public bool IsEmpty()
    {
        return count == 0;
    }

    // Display the stack from top to bottom
    public void PrintStack()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        for (int i = count - 1; i >= 0; i--)
        {
            Console.WriteLine(items[i]);
        }
    }
}
