// See https://aka.ms/new-console-template for more information

using Assignment3;

GenerateNumbersProblem g = new GenerateNumbersProblem();
int[] numbers = g.GenerateNumbers(15);
g.Reverse(numbers);
g.PrintNumbers(numbers);


 for (int i = 1; i <= 10; i++)
 {
     Console.Write($"{FibSequence.Fibonacci(i)} ");
 }



Color color1 = new Color(100, 200, 150);
Ball ball1 = new Ball(5, color1);

ball1.Throw();
ball1.Throw();
ball1.Throw();
Console.WriteLine("Ball 1 throw count: " + ball1.getNumThrows());

ball1.Pop();

ball1.Throw();
ball1.Throw();

Console.WriteLine("Ball 1 throw count: " + ball1.getNumThrows());

