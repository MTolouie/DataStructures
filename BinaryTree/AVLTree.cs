
using System.Runtime.CompilerServices;

namespace BinaryTree;

public class AVLTree
{
    public AVLNode Root { get; set; }

    public void insert(int value)
    {
        Root = insert(Root, value);
    }

    private AVLNode insert(AVLNode root, int value)
    {

        if (root is null)
        {
            root = new AVLNode(value);
            return root;
        }

        if (value < root.Value)
            root.LeftChild = insert(root.LeftChild, value);
        else
            root.RightChild = insert(root.RightChild, value);

        setHeight(root);

        root = balanced(root);

        return root;
    }

    private AVLNode balanced(AVLNode root)
    {

        if (isLeftHeavy(root))
        {
            Console.WriteLine($" {root.Value} left heavy");

            if (balanceFactor(root.LeftChild) < 0)
                root.LeftChild = leftRotation(root.LeftChild);
            //Console.WriteLine($"left Rotation On : {node.LeftChild.Value}");

            return rightRotation(root);

        }
        else if (isRightHeavy(root))
        {
            Console.WriteLine($" {root.Value} Right Heavy");

            if (balanceFactor(root.RightChild) > 0)
                root.RightChild = rightRotation(root.RightChild);

            return leftRotation(root);
        }

        return root;
    }

    private AVLNode leftRotation(AVLNode root)
    {
        var newRoot = root.RightChild;
        root.RightChild = newRoot.LeftChild;
        newRoot.LeftChild = root;

        setHeight(newRoot);
        setHeight(root);

        return newRoot;

    }

    private AVLNode rightRotation(AVLNode root)
    {
        var newRoot = root.LeftChild;
        root.LeftChild = newRoot.RightChild;
        newRoot.RightChild = root;

        setHeight(newRoot);
        setHeight(root);

        return newRoot;
    }

    private void setHeight(AVLNode node)
    {
        node.Height = Math.Max(height(node.LeftChild), height(node.RightChild)) + 1;
    }

    private int balanceFactor(AVLNode node)
    {
        return height(node.LeftChild) - height(node.RightChild);
    }

    private bool isLeftHeavy(AVLNode node)
    {
        return balanceFactor(node) > 1;
    }

    private bool isRightHeavy(AVLNode node)
    {
        return balanceFactor(node) < -1;
    }

    private int height(AVLNode node)
    {
        return (node is null ? -1 : node.Height);
    }

    private bool isLeaf(AVLNode node)
    {
        return node.LeftChild is null && node.RightChild is null;
    }
}
