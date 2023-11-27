using HashTables;

CharFinder Finder = new CharFinder();

//var result = Finder.findFirstNoneRepeatingChar("a green apple");

//Console.WriteLine(result);

//var result = Finder.findFirstRepeatingChar("a green apple");
//Console.WriteLine(result);

HashTable hashTable = new HashTable();
hashTable.put(6, "A");
hashTable.put(8, "B");
hashTable.put(11, "D");
hashTable.put(6, "A+");
hashTable.remove(60);
Console.WriteLine(hashTable.get(6));

Console.ReadKey();