namespace Assigment1;

public class GuessingProblem
{
    public void GuessingNumbers()
    {
        int correctNumber = new Random().Next(3) + 1;
        Console.Write("Guess what the number is: ");
        int guessedNumber = int.Parse(Console.ReadLine());
        while (guessedNumber != correctNumber)
        {
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your answer is outside of the range (less than 1 or more than 3)");
                Console.Write("Guess what the number is: ");
                guessedNumber = int.Parse(Console.ReadLine());
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("Your guess number  is high!");
                Console.Write("Guess what the number is: ");
                guessedNumber = int.Parse(Console.ReadLine());
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Your guess number  is low!");
                Console.Write("Guess what the number is: ");
                guessedNumber = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Your guess number is correct!");
        
    }
}