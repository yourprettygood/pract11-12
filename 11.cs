using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract11_12
{
    internal class Program
    {
        static void zadacha1()
        {
            //9.	Пусть даны целые числа а1, ..., а99. Получите новую последовательность, выбросив из исходной максимальный и минимальный члены.
            // Заранее заданный массив из 99 чисел
            int[] arr = new int[] {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
            31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
            41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
            51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
            61, 62, 63, 64, 65, 66, 67, 68, 69, 70,
            71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
            81, 82, 83, 84, 85, 86, 87, 88, 89, 90,
            91, 92, 93, 94, 95, 96, 97, 98, 99
        };

            // Находим минимальное и максимальное значение в массиве
            int minValue = arr.Min();
            int maxValue = arr.Max();

            // Выводим минимальное и максимальное значения для проверки
            Console.WriteLine($"Минимальное значение: {minValue}");
            Console.WriteLine($"Максимальное значение: {maxValue}");

            // Создаем новую последовательность, исключив все минимальные и максимальные значения
            var newArr = arr.Where(x => x != minValue && x != maxValue).ToArray();

            // Выводим результат
            Console.WriteLine("Новая последовательность (без всех минимальных и максимальных значений):");
            foreach (var num in newArr)
            {
                Console.Write(num + " ");
            }

        }



            static void zadacha2()
            {
            //Задание №2. Дан одномерный массив из действительных чисел:
            //9.	Все его элементы умножить на последний элемент;

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
        }




        static void zadacha3()
        {
            //9.	Известно количество осадков
            //(в миллиметрах), выпавших в Москве за каждый год в течение первых 50 лет нашего столетии.
            //Выяснить среднее количество осадков и отклонение от среднего для каждого года.
            double[] precipitation = new double[50]
{
            500.0, 510.0, 525.0, 490.0, 450.0, 520.0, 515.0, 530.0, 505.0, 485.0,
            475.0, 460.0, 505.0, 515.0, 490.0, 495.0, 510.0, 525.0, 520.0, 510.0,
            475.0, 500.0, 495.0, 505.0, 510.0, 485.0, 495.0, 515.0, 480.0, 470.0,
            490.0, 510.0, 515.0, 520.0, 495.0, 480.0, 500.0, 510.0, 505.0, 485.0,
            495.0, 475.0, 510.0, 525.0, 530.0, 520.0, 495.0, 485.0, 475.0, 470.0
};

            // Шаг 1: Вычисление среднего значения осадков
            double totalPrecipitation = 0;
            for (int i = 0; i < precipitation.Length; i++)
            {
                totalPrecipitation += precipitation[i];
            }
            double averagePrecipitation = totalPrecipitation / precipitation.Length;

            // Шаг 2: Вывод среднего значения
            Console.WriteLine($"Среднее количество осадков: {averagePrecipitation:F2} мм");

            // Шаг 3: Вычисление отклонений от среднего для каждого года
            Console.WriteLine("\nОтклонения от среднего количества осадков для каждого года:\n");
            for (int i = 0; i < precipitation.Length; i++)
            {
                double deviation = precipitation[i] - averagePrecipitation;
                Console.WriteLine($"Год {i + 1}: {deviation:F2} мм");
            }
        }
        
        static void Pract11()
        {
            Console.Write("Введите номер задачи:");
            short zadacha = short.Parse(Console.ReadLine());
           
            switch (zadacha)
            {
                case 1:
                    zadacha1();
                    break;

                case 2:
                    zadacha2();
                    break;
                case 3:
                    zadacha3();
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
