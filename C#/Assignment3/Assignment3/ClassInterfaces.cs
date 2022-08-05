namespace Assignment3;

public abstract class Person
{
    
    public int Age { get; set; }
    public string Address { get; set; }

    public virtual decimal CalculateSalary()
    {
        
    }
}
public class Student:Person
{
    public string[] Courses;
    public char[] Grades;
}

public class Instructor:Person
{
    public string Department { get; set; }
    public DateTime JoinDate { get; set; }
    public int Experience;
    public decimal BonusSalary()
    {
        
    }

    public override decimal CalculateSalary()
    {
        
    }
}
public class Course
{
    public Student[] EnrolledStudents;
}

public class Department
{
    public Instructor Head;
    public decimal Budget;
    public Course[] CoursesList;
}