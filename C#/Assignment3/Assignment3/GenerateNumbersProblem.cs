namespace Assignment3;

public struct GenerateNumbersProblem
{
    public int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 1; i < length + 1; i++)
        {
            numbers[i - 1] = i;
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
        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
    }
}