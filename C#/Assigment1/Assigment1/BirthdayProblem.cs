namespace Assigment1;

public class BirthdayProblem
{
    public void Birthday(DateTime date)
    {
        DateTime today = DateTime.Today;
        var diff = today - date;
        int days = diff.Days;
        Console.WriteLine($"You are is {days} days old");
        int daysToNextAnniversary = 10000 - (days % 10000);
        DateTime anniversary = today.AddDays(daysToNextAnniversary);
        Console.WriteLine($"Date of you next 10,000 day anniversary is {anniversary.Date.ToString("d")}");
        
    }
}