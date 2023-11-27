
namespace HashTables;

public class HashTable
{
    private class Entry
    {
        public int Key { get; set; }
        public string Value { get; set; }

        public Entry(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }

    LinkedList<Entry>[] Entries = new LinkedList<Entry>[5];

    public void put(int key, string value)
    {
        int index = hash(key);

        if (Entries[index] == null)
            Entries[index] = new LinkedList<Entry>();

        foreach (var entry in Entries[index])
        {
            if (entry.Key == key)
            {
                entry.Value = value;
                return;
            }
        }

        Entries[index].AddLast(new Entry(key, value));

    }

    public string get(int key)
    {
        int index = hash(key);

        if (Entries[index] is not null)
        {
            foreach (var entry in Entries[index])
                if (entry.Key == key)
                    return entry.Value;
        }

        return null;

    }

    public void remove(int key)
    {
        int index = hash(key);

        if (Entries[index] is null)
            throw new Exception($"No Entry With The Key Of {key}");

        foreach (var entry in Entries[index])
        {
            if(entry.Key == key)
            {
                Entries[index].Remove(entry);
                return;
            }
        }

        throw new Exception($"No Entry With The Key Of {key}");


    }


    private int hash(int key)
    {
        return key % Entries.Length;
    }

}
