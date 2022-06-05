using System.Globalization;
using Lists.Enums;
using Lists.Models;

namespace Lists.GenericLists;

public class GenericLists
{
    public void AverageValue()
    {
        Console.WriteLine("\nAverage value example\n");
        var numbers = new List<double>();
        var loopCondition = true;
        do
        {
            Console.Write("Enter the number: ");
            var numberString = Console.ReadLine();
            if (!double.TryParse(numberString, NumberStyles.Float,
                    new NumberFormatInfo(), out var number))
            {
                break;
            }

            numbers.Add(number);
            Console.WriteLine($"The average value: {numbers.Average()}");

            Console.WriteLine("Do you want to finish the application? (y/n)");
            var yesNoResponse = Console.ReadLine();
            if (yesNoResponse is "y" or "Y")
            {
                loopCondition = false;
            }
        } while (loopCondition);
    }

    public void ListOfPeople()
    {
        Console.WriteLine("\nList of people example\n");
        var people = new List<Person>
        {
            new Person()
            {
                Name = "Marcin",
                Country = CountryEnum.Pl, Age = 29
            },
            new Person()
            {
                Name = "Sabine",
                Country = CountryEnum.De, Age = 25
            },
            new Person()
            {
                Name = "Ann",
                Country = CountryEnum.De, Age = 31
            },
            new Person()
            {
                Name = "John",
                Country = CountryEnum.Uk, Age = 21
            }
        };

        Console.WriteLine("Sorting people by name");
        var results = people.OrderBy(p => p.Name).ToList();

        foreach (var person in results)
        {
            Console.WriteLine($"{person.Name} ({person.Age} years) from {person.Country}");
        }

        // Two ways to sorting a list based on a condition
        var names = people.Where(p => p.Age <= 30).OrderBy(p => p.Name).Select(p => p.Name).ToList();
        var names2 = (from p in people
            where p.Age <= 30
            orderby p.Name
            select p.Name).ToList();

        Console.WriteLine("Names of people under 30, sorted by names (Method 1)");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Names of people under 30, sorted by names (Method 2)");
        foreach (var name in names2)
        {
            Console.WriteLine(name);
        }
    }
}