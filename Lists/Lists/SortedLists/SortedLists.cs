using Lists.Enums;
using Lists.Models;

namespace Lists.SortedLists;

public class SortedLists
{
    public void AddressBook()
    {
        Console.WriteLine("\nAddress Book example\n");
        var people = new SortedList<string, Person>
        {
            {
                "Marcin", new Person()
                {
                    Name = "Marcin",
                    Country = CountryEnum.Pl, Age = 29
                }
            },
            {
                "Sabine", new Person()
                {
                    Name = "Sabine",
                    Country = CountryEnum.De, Age = 25
                }
            },
            {
                "Daniel", new Person()
                {
                    Name = "Daniel",
                    Country = CountryEnum.Pl, Age = 18
                }
            },
            {
                "Ann", new Person()
                {
                    Name = "Ann",
                    Country = CountryEnum.Uk, Age = 31
                }
            }
        };

        // This should be sorted by name
        foreach (var person in people)
        {
            Console.WriteLine($"{person.Value.Name} ({person.Value.Age} years) from {person.Value.Country}.");
        }
    }
}