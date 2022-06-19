namespace Forms.Models
{
    public record class Person(string Name, int Age, List<string> Languages, Dictionary<string, int> Phones);
}
