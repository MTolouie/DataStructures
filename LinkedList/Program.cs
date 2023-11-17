
LinkedList.LinkList.LinkedList linkedList = new LinkedList.LinkList.LinkedList();

linkedList.addFirst(50);
linkedList.addFirst(40);
linkedList.addFirst(30);
linkedList.addFirst(20);
linkedList.addFirst(10);

//linkedList.reverse();
var result = linkedList.getKthFromTheEnd(1);

linkedList.print();

Console.WriteLine();

Console.WriteLine(result);
Console.ReadKey();