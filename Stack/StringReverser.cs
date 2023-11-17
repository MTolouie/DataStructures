
using System.Text;

namespace Stack;

public class StringReverser
{

    public string reverseString(string str)
    {
        Stack<char> stack = new Stack<char>();

        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentNullException(nameof(str));
        }

        foreach (char c in str)
        {
            stack.Push(c);
        }

        StringBuilder sb = new StringBuilder();

        while (stack.Count != 0)
        {
          sb.Append(stack.Pop());   
        }
        return sb.ToString();
    }

}
