

using System.Collections.Concurrent;
using BuildSolution;

//var myPair = new IntPair(2, 5);

//Console.WriteLine($"({myPair.FirstValue}, {myPair.SecondValue})");

//var myPair2 = new StringPair("Alex", "Emi");

//Console.WriteLine($"({myPair2.FirstValue}, {myPair2.SecondValue})");

//var myPair3 = new Pair<int>(1, 3);

//Console.WriteLine($"({myPair3.FirstValue}, {myPair3.SecondValue})");


//var myList= new List<int> { 1, 2, 3, 4 };

//foreach(var item in myList.CustomWhere(x => x % 2 == 0))
//{
//    Console.WriteLine(item);
//}


var stack = new CustomStack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Top());
Console.WriteLine(stack.Top());

