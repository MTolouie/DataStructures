
namespace Heap;

public class CustomHeap
{
    public int[] Items = new int[10];
    public int Size { get; set; }

    public void insert(int value)
    {
        if (isFull())
            throw new OutOfMemoryException();

        Items[Size++] = value;

        // if newItem  is Greater Than Its parent We Have To Implement Bubble Up
        bubbleUp();
    }

    public void remove()
    {
        if(isEmpty())
            throw new NullReferenceException();

        Items[0] = Items[--Size];

        // if The New Root is Smaller Than Its Children We Have To Implement Bubble Down

        int index = 0;

        while (!isValidParent(index) && index <= Size)
        {
            int largerChildIndex = getLargerChildIndex(index);
            swap(index, largerChildIndex);
            index = largerChildIndex;
        }

    }
    private void bubbleUp()
    {
        int index = Size - 1;
        while (Items[index] > Items[findParentIndex(index)] && index > 0)
        {
            swap(index, findParentIndex(index));
            index = findParentIndex(index);
        }
    }

    private int getLargerChildIndex(int index)
    {
        return Items[findLeftChildIndex(index)] > Items[findRightChildIndex(index)]
               ? findLeftChildIndex(index)
               : findRightChildIndex(index);
    }

    private bool isValidParent(int index)
    {
        return Items[index] >= Items[findLeftChildIndex(index)] &&
               Items[index] >= Items[findRightChildIndex(index)];
    }

    private int findParentIndex(int index)
    {
        return (index - 1) / 2;
    }
    private int findLeftChildIndex(int index)
    {
        return index * 2 + 1;
    }
    private int findRightChildIndex(int index)
    {
        return index * 2 + 2;
    }

    public void swap(int first, int second)
    {
        var temp = Items[first];
        Items[first] = Items[second];
        Items[second] = temp;
    }

    public bool isFull()
    {
        return Size == Items.Length;
    }

    public bool isEmpty()
    {
        return Size == 0;
    }



}
