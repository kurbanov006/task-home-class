public class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Age { get; set; }
    public int CityId { get; set; }
}

public class City
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}