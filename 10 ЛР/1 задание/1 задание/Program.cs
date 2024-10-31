abstract class TelephoneDirectory : IComparable<TelephoneDirectory>
{
    public abstract void PrintInfo();

    public abstract bool MatchesSearchCriteria(string searchTerm);

    public int CompareTo(TelephoneDirectory other)
    {
        // Сравниваем по номеру телефона
        return GetPhoneNumber().CompareTo(other.GetPhoneNumber());
    }

    protected abstract string GetPhoneNumber();
}

class Persona : TelephoneDirectory
{
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public override void PrintInfo()
    {
        Console.WriteLine($"Persona: {LastName}, Address: {Address}, Phone: {PhoneNumber}");
    }

    public override bool MatchesSearchCriteria(string searchTerm)
    {
        return LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);
    }

    protected override string GetPhoneNumber()
    {
        return PhoneNumber;
    }
}

class Organization : TelephoneDirectory
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string ContactPerson { get; set; }

    public override void PrintInfo()
    {
        Console.WriteLine($"Organization: {Name}, Address: {Address}, Phone: {Phone}, Fax: {Fax}, Contact: {ContactPerson}");
    }

    public override bool MatchesSearchCriteria(string searchTerm)
    {
        return Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);
    }

    protected override string GetPhoneNumber()
    {
        return Phone;
    }
}

class Friend : TelephoneDirectory
{
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }

    public override void PrintInfo()
    {
        Console.WriteLine($"Friend: {LastName}, Address: {Address}, Phone: {PhoneNumber}, Birthday: {BirthDate.ToShortDateString()}");
    }

    public override bool MatchesSearchCriteria(string searchTerm)
    {
        return LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);
    }

    protected override string GetPhoneNumber()
    {
        return PhoneNumber;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string filePath = "directory.txt"; // Путь к файлу с данными
        List<TelephoneDirectory> directory = new List<TelephoneDirectory>();

        // Чтение данных из файла
        try
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts[0] == "Persona")
                {
                    directory.Add(new Persona
                    {
                        LastName = parts[1],
                        Address = parts[2],
                        PhoneNumber = parts[3]
                    });
                }
                else if (parts[0] == "Organization")
                {
                    directory.Add(new Organization
                    {
                        Name = parts[1],
                        Address = parts[2],
                        Phone = parts[3],
                        Fax = parts[4],
                        ContactPerson = parts[5]
                    });
                }
                else if (parts[0] == "Friend")
                {
                    directory.Add(new Friend
                    {
                        LastName = parts[1],
                        Address = parts[2],
                        PhoneNumber = parts[3],
                        BirthDate = DateTime.Parse(parts[4])
                    });
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            return;
        }

        // Сортируем по номеру телефона
        directory.Sort();

        // Выводим полную информацию
        Console.WriteLine("Полная информация записи в телефонном справочнике:");
        foreach (var entry in directory)
        {
            entry.PrintInfo();
        }

        // Поиск по фамилии
        Console.WriteLine("\nВведите фамилию для поиска:");
        string searchTerm = Console.ReadLine();
        var searchResults = directory.Where(entry => entry.MatchesSearchCriteria(searchTerm)).ToList();

        if (searchResults.Any())
        {
            Console.WriteLine("Результаты поиска:");
            foreach (var result in searchResults)
            {
                result.PrintInfo();
            }
        }
        else
        {
            Console.WriteLine("Записи не найдены.");
        }
    }
}