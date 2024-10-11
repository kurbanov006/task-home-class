public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int Age { get; set; }
    public string Gender { get; set; } = null!;
    public string Status { get; set; } = null!;
    public DateTime DateOfStart { get; set; }
    public DateTime DateOfFinish { get; set; }
}