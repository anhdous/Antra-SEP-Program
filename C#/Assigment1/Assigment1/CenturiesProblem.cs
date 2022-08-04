namespace Assigment1;

// Write program to enter an integer number of centuries and convert it to years, days, hours,
//     minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
// type for every data conversion. Beware of overflows!
public class CenturiesProblem
{
    public void ConvertCenturies(int centuries)
    {
        uint years, days, hours;
        ulong minutes, seconds, milliseconds, microseconds, nanoseconds;
        years = (uint)centuries * 100;
        days = years * 365 + years / 4 - years / 100 + years/400;
        hours = days * 24;
        minutes = (ulong)hours * 60;
        seconds = minutes * 60;
        milliseconds = seconds * 1000;
        microseconds = milliseconds * 1000;
        nanoseconds = microseconds * 1000;
            
            
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes " +
                          $"= {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds " +
                          $"= {nanoseconds} nanoseconds");
        
    }
}