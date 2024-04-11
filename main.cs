/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

sing System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] students = { "Иванов", "Петров", "Сидоров", "Козлов", "Смирнов" };
        double[] results = { 10.5, 10.2, 10.8, 10.3, 10.1 };

        // Сортируем результаты по времени бега
        Array.Sort(results, students);

        // Выводим четырех лучших бегунов
        Console.WriteLine("Команда из четырех лучших бегунов:");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(students[i] + " - " + results[i] + " сек");
        }
    }
}
