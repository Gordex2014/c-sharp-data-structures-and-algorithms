using Lists.Enums;

namespace Lists.Models;

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public CountryEnum Country { get; set; }
}