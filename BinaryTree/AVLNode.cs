
namespace BinaryTree;

public class AVLNode
{
    public int Value { get; set; }
    public AVLNode LeftChild{ get; set; }
    public AVLNode RightChild { get; set; }
    public int Height { get; set; }

    public AVLNode(int value)
    {
        this.Value = value;
    }

    public override string ToString()
    {
        return $"Value = {this.Value}";
    }
}
