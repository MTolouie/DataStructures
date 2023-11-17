
using Stack;

//string str = "abcdef";

//StringReverser reverser = new StringReverser();
//string reversed = reverser.reverseString(str);

//string str = "({1+2})";

//Expression expression = new Expression();

//var result = expression.isBalanced(str);

CustomStack stack = new CustomStack();

//stack.push(10);
//stack.push(20);
//stack.push(30);
//stack.push(40);

//var usedToBeTop = stack.pop();

stack.print();
//var peek = stack.peek();

var result = stack.isEmpty();

Console.WriteLine($"Peek Result : {result}");

Console.ReadKey();