// See https://aka.ms/new-console-template for more information

using Assignment4;

MyStack<int> stack = new MyStack<int>();
stack.Push(2);
stack.Push(5);
Console.WriteLine($"Pop {stack.Pop()}");
Console.WriteLine("Stack count " + stack.Count());


MyList<string> list = new MyList<string>();
list.Add("Anh");
Console.WriteLine(list.Find(2));
