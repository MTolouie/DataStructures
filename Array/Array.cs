
namespace DataStructures.Array;

public class Array
{
    private int[] numbers;
    private int count = 0;
    public Array(int length)
    {
        numbers = new int[length];
    }

    public void insert(int value)
    {

        if (numbers.Length == count)
        {
            int[] newNumbers = new int[count + 1];
            for (int i = 0; i < count; i++)
            {
                newNumbers[i] = numbers[i];
            }
            numbers = newNumbers;

        }

        numbers[count++] = value;

    }

    public void removeAt(int index)
    {
        if (index < 0 || index >= count)
            throw new ArgumentException("Index out of range");


        for (int i = index; i < count; i++)
        {
            if (index == count - 1) // Removing the last element
            {
                continue;
            }
            numbers[i] = numbers[i + 1];
        }
        count--;

    }

    public int indexOf(int value)
    {
        for (int i = 0; i < count; i++)
        {
            if (numbers[i] == value)
                return i;
        }
        return -1;
    }

    public void print()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
