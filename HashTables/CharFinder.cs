
namespace HashTables;

public class CharFinder
{
    public Dictionary<char, int> dict = new();
    public char findFirstNoneRepeatingChar(string str)
    {
        foreach (var item in str)
        {
            if (dict.ContainsKey(item))
            {
                var value = dict.GetValueOrDefault(item);
                //dict.Add(item, value+1);  
                dict[item] = value+1;
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
}
