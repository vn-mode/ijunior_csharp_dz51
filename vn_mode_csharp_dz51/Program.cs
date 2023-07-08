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

        int height = ReadValidInteger("Введите рост:");
        int weight = ReadValidInteger("Введите вес:");
        string nationality = ReadInput("Введите национальность:");

        var result = FindMatchingCriminals(criminals, height, weight, nationality);

        DisplayResults(result);

        Console.ReadLine();
    }

    static int ReadValidInteger(string message)
    {
        int value;
        bool isValidInput;

        do
        {
            Console.WriteLine(message);
            isValidInput = int.TryParse(Console.ReadLine(), out value);

            if (!isValidInput)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }

        } while (!isValidInput);

        return value;
    }

    static string ReadInput(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }

    static IEnumerable<Criminal> FindMatchingCriminals(List<Criminal> criminals, int height, int weight, string nationality)
    {
        return criminals.Where(criminal => !criminal.IsInPrison && criminal.Height == height && criminal.Weight == weight && criminal.Nationality == nationality);
    }

    static void DisplayResults(IEnumerable<Criminal> criminals)
    {
        Console.WriteLine("Результат:");

        foreach (var criminal in criminals)
        {
            Console.WriteLine(criminal.FullName);
        }
    }
}

class Criminal
{
    public string FullName { get; }
    public bool IsInPrison { get; }
    public int Height { get; }
    public int Weight { get; }
    public string Nationality { get; }

    public Criminal(string fullName, bool isInPrison, int height, int weight, string nationality)
    {
        FullName = fullName;
        IsInPrison = isInPrison;
        Height = height;
        Weight = weight;
        Nationality = nationality;
    }
}
