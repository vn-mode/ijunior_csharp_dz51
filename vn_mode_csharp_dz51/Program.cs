using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Criminal> criminals = new List<Criminal>
        {
            new Criminal("Иванов Иван Иванович", true, 180, 80, "Русский"),
            new Criminal("Петров Пётр Петрович", false, 170, 70, "Украинец"),
            new Criminal("Сидоров Сидр Сидорович", true, 190, 90, "Русский"),
            new Criminal("Смирнов Алейсей Владимирович", false, 175, 75, "Русский"),
        };

        Console.WriteLine("Введите рост:");
        int height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите вес:");
        int weight = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите национальность:");
        string nationality = Console.ReadLine();

        var result = criminals.Where(c => !c.IsInPrison && c.Height == height && c.Weight == weight && c.Nationality == nationality);

        Console.WriteLine("Результат:");

        foreach (var criminal in result)
        {
            Console.WriteLine(criminal.FullName);
        }

        Console.ReadLine();
    }
}

class Criminal
{
    public string FullName { get; set; }
    public bool IsInPrison { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public string Nationality { get; set; }

    public Criminal(string fullName, bool isInPrison, int height, int weight, string nationality)
    {
        FullName = fullName;
        IsInPrison = isInPrison;
        Height = height;
        Weight = weight;
        Nationality = nationality;
    }
}
