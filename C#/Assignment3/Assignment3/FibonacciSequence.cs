namespace Assignment3;

public class FibSequence
{
    public static int Fibonacci(int num)
    {
        if (num == 1 || num == 2)
        {
            return 1;
        }
        else
        {
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        } 
    }
}