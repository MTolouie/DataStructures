
namespace LinkedList.LinkList;

public class LinkedList
{
    private Node First { get; set; }
    private Node Last { get; set; }

    private int Size { get; set; }


    public void addFirst(int value)
    {
        var tempNode = First;

        Node toBeAddedNode = new Node();
        toBeAddedNode.value = value;
        toBeAddedNode.NextNode = tempNode;

        First = toBeAddedNode;

        if (First.NextNode is null)
            Last = First;

        Size++;
    }

    public void addLast(int value)
    {
        //var tempNode = Last;

        Node toBeAddedNode = new Node();
        toBeAddedNode.value = value;
        toBeAddedNode.NextNode = null;

        //var Node = First;

        //while (Node.NextNode is not null)
        //{
        //    if (Node.NextNode.NextNode == null)
        //    {
        //        Node.NextNode = Last;
        //        Last.NextNode = toBeAddedNode;
        //        Last = toBeAddedNode;
        //        break;
        //    }
        //    else
        //    {
        //        Node = Node.NextNode;
        //    }
        //}

        if (First is null)
        {
            First = toBeAddedNode;
            Last = toBeAddedNode;
        }
        else
        {
            Last.NextNode = toBeAddedNode;
            Last = toBeAddedNode;
        }

        Size++;


    }


    public int indexOf(int value)
    {
        var Node = First;
        int i = 0;
        while (Node is not null)
        {

            if (Node.value == value)
            {
                return i;
            }
            i++;
            Node = Node.NextNode;
        }

        return -1;
    }

    public bool contains(int value)
    {
        return indexOf(value) != -1;
    }

    public void removeFirst()
    {

        if (First == null)
        {
            throw new NullReferenceException();
        }

        if (First == Last)
        {
            Last = First = null;
            Size--;
            return;
        }

        var secondNode = First.NextNode;
        First.NextNode = null;
        First = secondNode;

        Size--;
    }

    public void removeLast()
    {
        var Node = First;

        if (First is null)
        {
            throw new NullReferenceException();
        }

        if (First == Last)
        {
            Last = First = null;
            Size--;
            return;
        }

        while (Node.NextNode is not null)
        {
            if (Node.NextNode.NextNode == null)
            {
                Node.NextNode = null;
                Last = Node;
                break;
            }
            else
            {
                Node = Node.NextNode;
            }
        }

        Size--;

    }

    public int size()
    {
        //Node node = First;
        //int i = 0;
        //while(node is not null)
        //{
        //    node = node.NextNode;
        //    i++;
        //}
        //return i;
        return Size;
    }


    public int[] toArray()
    {
        int[] array = new int[Size];

        int i = 0;
        Node node = First;

        while (node != null)
        {
            array[i] = node.value;
            i++;
            node = node.NextNode;
        }

        return array;

    }

    public void reverse()
    {
        //[10 <= 20 <= 30 => 40 => 50 => 60]
        //  p     c     n

        if (First == null)
            return;

        Node prev = First;
        Node current = First.NextNode;

        while (current != null)
        {
            Node next = current.NextNode;
            current.NextNode = prev;
            prev = current;
            current = next;
        }

        Last = First;
        Last.NextNode = null;
        First = prev;


    }


    public int getKthFromTheEnd(int k)
    {

        if(First is null)
            throw new NullReferenceException();

        int distance = k - 1;

        Node firstPointer = First;
        Node secondPointer = First;

        for (int i = 0; i < distance; i++)
        {
            secondPointer = secondPointer.NextNode;

            if(secondPointer is null)
                throw new ArgumentOutOfRangeException();
        }

        while(secondPointer.NextNode != null) 
        {
            firstPointer = firstPointer.NextNode;
            secondPointer = secondPointer.NextNode;
        }

        return firstPointer.value;

    }

    public void print()
    {
        Console.WriteLine(First?.value);
        Console.WriteLine(Last?.value);

        Console.WriteLine("------------------------");
        var Node = First;
        while (Node != null)
        {
            Console.Write(Node.value + " ");
            Node = Node.NextNode;
        }
    }
}
