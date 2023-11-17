
namespace Stack;

public class Expression
{

    private readonly List<char> LeftBrackets = new List<char>() { '(', '{', '<', '[' };
    private readonly List<char> RightBrackets = new List<char>() { ')', '}', '>', ']' };

    public bool isBalanced(string expression)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in expression)
        {

            if (isLeftBracket(c))
                stack.Push(c);

            if (isRightBracket(c))
            {
                if (stack.Count == 0)
                    return false;

                var top = stack.Pop();
                if (!bracketsMatch(top, c))
                    return false;

            }

        }

        if (stack.Count == 0)
            return true;

        return false;
    }

    private bool isLeftBracket(char c)
    {
        return LeftBrackets.Contains(c);
    }

    private bool isRightBracket(char c)
    {
        return RightBrackets.Contains(c);
    }

    private bool bracketsMatch(char left, char right)
    {
        return LeftBrackets.IndexOf(left) == RightBrackets.IndexOf(right);
    }
}
