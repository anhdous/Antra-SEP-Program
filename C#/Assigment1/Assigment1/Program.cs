using Assigment1;

TypesProblem q1 = new TypesProblem();
q1.Type();

CenturiesProblem q2 = new CenturiesProblem();
q2.ConvertCenturies(1);
q2.ConvertCenturies(5);

FizzBuzzProblem q3 = new FizzBuzzProblem();
foreach (var item in q3.FizzBuzz())
{
    Console.WriteLine(item);
}

GuessingProblem q4 = new GuessingProblem();
q4.GuessingNumbers();

PyramidProblem q5 = new PyramidProblem();
q5.PrintAPyramid();

BirthdayProblem q6 = new BirthdayProblem();
DateTime birthday = new DateTime(1996, 08, 31);
q6.Birthday(birthday);

GreetingProblem q7 = new GreetingProblem();
DateTime currentDateTime = DateTime.Now;
q7.Greeting(currentDateTime);

CountingProblem q8 = new CountingProblem();
q8.Counting();

