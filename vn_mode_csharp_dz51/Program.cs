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

        int height;
        bool isValidHeight;

        do
        {
            Console.WriteLine("Введите рост:");
            isValidHeight = int.TryParse(Console.ReadLine(), out height);

            if (!isValidHeight)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число для роста.");
            }

        } while (!isValidHeight);

        int weight;
        bool isValidWeight;

        do
        {
            Console.WriteLine("Введите вес:");
            isValidWeight = int.TryParse(Console.ReadLine(), out weight);

            if (!isValidWeight)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число для веса.");
            }

        } while (!isValidWeight);

        Console.WriteLine("Введите национальность:");
        string nationality = Console.ReadLine();

        var result = criminals.Where(criminal => !criminal.IsInPrison && criminal.Height == height && criminal.Weight == weight && criminal.Nationality == nationality);

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
