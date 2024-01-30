using ComparingObjects;

List<Person> people = new();

string command;

while ((command = Console.ReadLine()) != "END")
{
    string[] personProps = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Person person = new()
    {
        Name = personProps[0],
        Age = int.Parse(personProps[1]),
        Town = personProps[2]
    };

    people.Add(person);
}

int compareIndex = int.Parse(Console.ReadLine()) - 1;

Person persontoCompare = people[compareIndex];

int euqalCount = 0;
int diffCount = 0;

foreach (var person in people)
{
    if (person.CompareTo(persontoCompare)== 0)
    {
        euqalCount++;
    }
    else
    {
        diffCount++;
    }
}

if (euqalCount == 1)
{
    Console.WriteLine("No matches");
}
else
{
    Console.WriteLine($"{euqalCount} {diffCount} {people.Count}");
}
