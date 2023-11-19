using BinaryTree;
AVLTree tree = new AVLTree();

tree.insert(10);
tree.insert(30);
tree.insert(20);

BTreePrinter.Print(tree.Root);

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine(tree.Root.Height);
//var result = tree.find(100);

//tree.traversePreOrder(tree.Root);
//var result = tree.min();

//var isEqual = tree.equal(secondTree);

//var result = tree.isBinarySearchTree();
//Console.WriteLine(result);

//Console.WriteLine(tree.ToString());

Console.ReadKey();