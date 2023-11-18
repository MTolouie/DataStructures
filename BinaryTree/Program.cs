using BinaryTree;
CustomBinaryTree tree = new CustomBinaryTree();

tree.insert(7);
tree.insert(4);
tree.insert(9);
tree.insert(1);
tree.insert(6);
tree.insert(8);
tree.insert(10);

BTreePrinter.Print(tree.Root);

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

tree.printKthNode(1);


//var result = tree.find(100);

//tree.traversePreOrder(tree.Root);
//var result = tree.min();

//var isEqual = tree.equal(secondTree);

//var result = tree.isBinarySearchTree();
//Console.WriteLine(result);

//Console.WriteLine(tree.ToString());

Console.ReadKey();