namespace Assignment3;

public struct GenerateNumbersProblem
{
    public int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        Random r = new Random();
        for (int i = 0; i < length; i++)
        {
            numbers[i] = r.Next(int.MinValue,int.MaxValue) ;
        }

        return numbers;
    }

    public int[] Reverse(int[] numbers)
    {
        int len = numbers.Length;
        for (int i = 0; i < len / 2; i++)
        {
            int temp = numbers[i];
            numbers[i] = numbers[len - i - 1];
            numbers[len - i - 1] = temp;
        }

        return numbers;
    }

    public void PrintNumbers(int[] numbers)
    {
        foreach (var num in numbers)
        {
            Console.Write($"{num} ");
        }
    }
}