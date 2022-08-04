namespace Assigment1;

public class GreetingProblem
{
    public void Greeting(DateTime currentDateTime)
    {
        int currentHour = currentDateTime.Hour;
        int startMorningHour = 6;
        int startAfternoonHour = 12;
        int startEveningHour = 17;
        int startNightHour = 22;
        if (startMorningHour <= currentHour && currentHour < startAfternoonHour)
        {
            Console.WriteLine("Good morning!");
        }
        if (startAfternoonHour <= currentHour && currentHour < startEveningHour)
        {
            Console.WriteLine("Good Afternoon!");
        }
        if (startEveningHour <= currentHour && currentHour < startNightHour)
        {
            Console.WriteLine("Good Evening!");
        }
        if (startNightHour <= currentHour || currentHour < startMorningHour)
        {
            Console.WriteLine("Good Night!");
        }
    }
}