
namespace HashTables;

public class CharFinder
{
    public char findFirstNoneRepeatingChar(string str)
    {
        Dictionary<char, int> dict = new();

        foreach (var item in str)
        {
            if (dict.ContainsKey(item))
            {
                var value = dict.GetValueOrDefault(item);
                //dict.Add(item, value+1);  
                dict[item] = value + 1;
            }
            else
            {
                dict.Add(item, 1);
            }
        }

        foreach (var item in str)
        {
            var key = dict.SingleOrDefault(v => v.Key == item);
            if (key.Value == 1)
                return key.Key;

        }
        return char.MinValue;
    }

    public char findFirstRepeatingChar(string str)
    {
        HashSet<char> set = new HashSet<char>();

        foreach (var item in str)
        {
            if (set.Contains(item))
                return item;

            set.Add(item);
        }

        return char.MinValue;
    }
}
