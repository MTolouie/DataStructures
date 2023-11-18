
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BinaryTree;

public class CustomBinaryTree
{
    public Node Root { get; set; }

    public void insert(int value)
    {
        if (Root is null)
        {
            Root = new Node(value);
            return;
        }

        Node current = Root;

        while (true)
        {
            if (value > current.Value)
            {
                if (current.RightChild is null)
                {
                    Node newNode = new Node(value);
                    current.RightChild = newNode;
                    break;
                }
                current = current.RightChild;
            }
            else
            {
                if (current.LeftChild is null)
                {
                    Node newNode = new Node(value);
                    current.LeftChild = newNode;
                    break;
                }
                current = current.LeftChild;
            }
        }

    }

    public bool find(int value)
    {
        Node current = Root;

        while (current is not null)
        {
            if (value > current.Value)
            {
                current = current.RightChild;
            }
            else if (value < current.Value)
            {
                current = current.LeftChild;
            }
            else
            {
                return true;
            }
        }

        return false;

    }

    public void traversePreOrder(Node root)
    {
        if (root == null)
            return;

        // root left right

        Console.WriteLine(root.Value);

        traversePreOrder(root.LeftChild);
        traversePreOrder(root.RightChild);

    }

    public void traverseInOrder(Node root)
    {
        if (root is null)
            return;

        // left root right

        traverseInOrder(root.LeftChild);

        Console.WriteLine(root.Value);

        traverseInOrder(root.RightChild);

    }

    public void traversePostOrder(Node root)
    {
        if (root is null)
            return;

        // left right root

        traversePostOrder(root.LeftChild);

        traversePostOrder(root.RightChild);

        Console.WriteLine(root.Value);

    }

    public int height(Node root)
    {
        if (root == null)
            return -1;

        if (isLeaf(root))
            return 0;

        return 1 + Math.Max(height(root.LeftChild), height(root.RightChild));
    }

    //o(log n)
    //this is for those times when a tree is a binary search tree
    public int min()
    {

        if (Root == null)
            throw new NullReferenceException();

        Node current = Root;
        Node last = Root;

        while (current != null)
        {
            last = current;
            current = current.LeftChild;
        }
        return last.Value;
    }


    //o(n)
    //this is for those times when a tree is " NOT "  a binary search tree
    public int min(Node root)
    {

        if (isLeaf(root))
            return root.Value;

        var leftMinimum = min(root.LeftChild);
        var rightMinimum = min(root.RightChild);

        var minimumOfLeftAndRight = Math.Min(leftMinimum, rightMinimum);

        return Math.Min(minimumOfLeftAndRight, root.Value);

    }

    public bool equal(CustomBinaryTree secondTree)
    {
        if (secondTree is null)
            return false;

        return equal(Root,secondTree.Root);

    }

    private bool equal(Node first,Node second)
    {
        if (first is null && second is null)
            return true;

        if(first is not null && second is not null)
            return first.Value == second.Value &&
                   equal(first.LeftChild, second.LeftChild) &&
                   equal(first.RightChild, second.RightChild);

        return false;
    }


    public bool isBinarySearchTree()
    {
        return isBinarySearchTree(Root, int.MinValue, int.MaxValue);
    }
    private bool isBinarySearchTree(Node root,int minValue,int maxValue)
    {
        if (root == null)
            return true;

        if (root.Value > maxValue || root.Value < minValue)
            return false;

        return isBinarySearchTree(root.LeftChild, minValue, root.Value-1) &&
               isBinarySearchTree(root.RightChild, root.Value +1, maxValue);

    }

    public void printKthNode(int distance)
    {
        printKthNode(Root,distance);
    }

    private void printKthNode(Node root,int distance)
    {
        if (root == null)
            return;

        if(distance == 0)
        {
            Console.WriteLine(root.Value);
            return;
        }

        printKthNode(root.LeftChild,distance - 1);
        printKthNode(root.RightChild,distance - 1);
    }


    public override string ToString()
    {
        return $"Node : {this.Root.Value}";
    }

    private bool isLeaf(Node node)
    {
        return node.LeftChild == null && node.RightChild == null;
    }

}
