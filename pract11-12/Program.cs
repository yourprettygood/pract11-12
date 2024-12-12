using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract11_12
{
    internal class Program
    {
        static void Pract11()
        {
            Console.Write("Введите номер задачи:");
            short zadacha = short.Parse(Console.ReadLine());
            switch (zadacha)
            {
                case 1://9.	Пусть даны целые числа а1, ..., а99. Получите новую последовательность, выбросив из исходной максимальный и минимальный члены.
                    Random rand = new Random();
                    int[] array = new int[99];

                    // Заполнение массива случайными числами
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = rand.Next(1, 101); // Случайные числа от 1 до 100
                    }

                    // Выводим исходный массив
                    Console.WriteLine("Исходный массив:");
                    foreach (int num in array)
                    {
                        Console.Write(num + " ");
                    }
                    Console.WriteLine();

                    // Находим максимальный и минимальный элементы
                    int maxElement = array.Max();
                    int minElement = array.Min();

                    // Создаем новую последовательность, исключая максимальный и минимальный элементы
                    int[] newArray = array.Where(x => x != maxElement && x != minElement).ToArray();

                    // Выводим новую последовательность
                    Console.WriteLine("Новая последовательность:");
                    foreach (int num in newArray)
                    {
                        Console.Write(num + " ");
                    }


                    break;

                    case 2:
                    Console.Write("Введите количество элементов в массиве: ");
                    int n = int.Parse(Console.ReadLine());
                    double[] arrays = new double[n];

                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < n; i++)
                    {
                        arrays[i] = double.Parse(Console.ReadLine());
                    }

                    double lastElement = arrays[arrays.Length - 1];

                    // Умножаем все элементы массива на последний элемент
                    for (int i = 0; i < arrays.Length; i++)
                    {
                        arrays[i] *= lastElement;
                    }

                    // Выводим измененный массив
                    Console.WriteLine("Измененный массив:");
                    foreach (double num in arrays)
                    {
                        Console.Write(num + " ");
                    }

                    break;
                case 3:
                    Random rands = new Random();
                    double[] precipitation = new double[50];

                    // Заполнение массива случайными числами
                    for (int i = 0; i < precipitation.Length; i++)
                    {
                        precipitation[i] = rands.NextDouble() * 100; // Случайные числа от 0 до 100
                    }

                    // Выводим исходный массив
                    Console.WriteLine("Количество осадков за каждый год:");
                    foreach (double num in precipitation)
                    {
                        Console.Write(num + " ");
                    }
                    Console.WriteLine();

                    // Вычисляем среднее количество осадков
                    double average = precipitation.Average();

                    // Вычисляем отклонение от среднего для каждого года
                    double[] deviations = new double[precipitation.Length];
                    for (int i = 0; i < precipitation.Length; i++)
                    {
                        deviations[i] = precipitation[i] - average;
                    }

                    // Выводим результаты
                    Console.WriteLine("Среднее количество осадков: " + average);
                    Console.WriteLine("Отклонения от среднего для каждого года:");
                    for (int i = 0; i < deviations.Length; i++)
                    {
                        Console.WriteLine("Год " + (i + 1) + ": " + deviations[i]);
                    }





                    break;
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Введите номер Практической работы(11,12):");
            short numb = short.Parse(Console.ReadLine());
            switch (numb)
            {
                case 11:
                    Pract11();
                    break;
            }
        }
    }
}

