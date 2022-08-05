namespace Assignment3;

public abstract class Person{
    public int Id { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Age
    {
        get
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
    public List<string> Address { get; set; }
    public void GetAddress(List<string> Address)
    {
        foreach (var item in Address)
        {
            Console.WriteLine(item);
        }
    }

    private double salary;
    public double Salary
    {
        get
        {
            return salary;
        }
        set
        {
            if (salary < 0)
            {
                throw new ArgumentException("Only positive values are allowed");
            }

            salary = value;
        }
    }
}
public class Student:Person
{
    public List<Course> SelectedCourses { get; set; }
}

public class Instructor:Person
{
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

}
public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Student> EnrolledStudents { get; set; }
}

public enum Grade
{
    A,B,C,D,E,F
}
public class CourseEnrollment
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public Student Student { get; set; }
    public Course Course { get; set; }
    public Grade Grade { get; set; }
    public double CalculateGPA()
    {
        throw new NotImplementedException();
    }
}
public class Department
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
    public DateTime JoinDate { get; set; }

    public int YearOfExperience
    {
        get { return DateTime.Now.Year - JoinDate.Year; }
    }
    public decimal Budget { get; set; }
    public int HeadId { get; set; }
    public Instructor Head { get; set; }
    public List<Course> ProvidedCourses { get; set; }
}