
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BinaryTree;

public class CustomBinaryTree
{
    private class NodeInfo
    {
        public Node Node;
        public string Text;
        public int StartPos;
        public int Size { get { return Text.Length; } }
        public int EndPos { get { return StartPos + Size; } set { StartPos = value - Size; } }
        public NodeInfo Parent, Left, Right;
    }
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
    public override string ToString()
    {
        return $"Node : {this.Root.Value}";
    }


}
