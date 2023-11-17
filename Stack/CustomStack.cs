
namespace Stack;

public class CustomStack
{
    public int ElementsCount { get; set; } = 0;
    public int Top { get; set; }

    public int[] StackElements = new int[10];

    public void push(int value)
    {
        if(ElementsCount == StackElements.Length)
            throw new StackOverflowException();

        StackElements[ElementsCount] = value;
        Top = StackElements[ElementsCount];
        ElementsCount++;
    }

    public int pop()
    {
        if (ElementsCount == 0)
            throw new NullReferenceException();

        var usedToBeTop = StackElements[ElementsCount-1];

        ElementsCount--;
        Top = StackElements[ElementsCount-1];

        return usedToBeTop;
    }

    public int peek()
    {
        return Top;
    }

    public bool isEmpty()
    {
        return ElementsCount == 0;
    }

    public void print()
    {

        Console.WriteLine($"Top Is : {Top}");

        Console.WriteLine("///////////////");

        for (int i = 0; i < ElementsCount; i++)
        {
            Console.WriteLine(StackElements[i]);
        }
    }
}
