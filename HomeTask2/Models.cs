using System.Reflection.PortableExecutable;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
}


public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int Credits { get; set; }
}

public class Enrollment
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public DateTime EnrollmentDate { get; set; }
}

