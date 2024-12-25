using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void zadacha1()//Задание №1. Обработка матриц
                              //9.	Найти максимальный элемент матрицы А(6х10) и его порядковый номер.
        {
            // Инициализация матрицы размером 6x10
            int[,] matrix = new int[6, 10];
            Random rand = new Random();

            // Заполнение матрицы случайными числами и вывод на экран
            Console.WriteLine("Матрица:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rand.Next(1, 101); // числа от 1 до 100
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Поиск максимального элемента и его порядкового номера
            int maxElement = matrix[0, 0];
            int maxRow = 0, maxCol = 0;
            int linearIndex = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                        maxRow = i;
                        maxCol = j;
                        linearIndex = i * 10 + j + 1; // Порядковый номер
                    }
                }
            }

            // Вывод результата
            Console.WriteLine($"\nМаксимальный элемент: {maxElement}");
            Console.WriteLine($"Индексы (строка, столбец): ({maxRow + 1}, {maxCol + 1})");
            Console.WriteLine($"Порядковый номер: {linearIndex}");
        }

        static void zadacha2()//Задание №2. Дана целочисленная прямоугольная матрица:
        {
            //9.	Найти сумму элементов в тех столбцах, которые не содержат отрицательных элементов.
            // Инициализация матрицы
            int[,] matrix = new int[4, 6];
            Random rand = new Random();

            // Заполнение матрицы случайными числами и вывод на экран
            Console.WriteLine("Матрица:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(-10, 21); // числа от -10 до 20
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Поиск суммы элементов в столбцах без отрицательных элементов
            Console.WriteLine("\nСуммы элементов в столбцах без отрицательных чисел:");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool hasNegative = false;
                int columnSum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                    columnSum += matrix[i, j];
                }

                if (!hasNegative)
                {
                    Console.WriteLine($"Столбец {j + 1}: сумма = {columnSum}");
                }
            }

        }

        static void zadacha3()
        {
            //9.	В двумерном массиве хранится информация о баллах,
            //полученных спортсменами-пятиборцами в каждом из пяти видов спорта
            //(в первом столбце – информация о баллах первого спортсмена,  во втором – второго и т.д.).
            //Общее число спортсменов равно 20. Составить программу для расчета общей суммы баллов, набранных любым спортсменом.

            // Инициализация матрицы 5x20 (5 видов спорта и 20 спортсменов)
            // Инициализация матрицы 5x20 (5 видов спорта и 20 спортсменов)
            int[,] scores = new int[5, 20];
            Random rand = new Random();

            // Заполнение матрицы случайными баллами
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                for (int j = 0; j < scores.GetLength(1); j++)
                {
                    scores[i, j] = rand.Next(5, 16); // баллы от 5 до 15
                }
            }

            // Вывод таблицы баллов спортсменов
            Console.WriteLine("Таблица баллов спортсменов (5 видов спорта, 20 спортсменов):");
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                for (int j = 0; j < scores.GetLength(1); j++)
                {
                    Console.Write($"{scores[i, j],4}"); // Ровное выравнивание на 4 символа
                }
                Console.WriteLine();
            }

            // Расчет и вывод общих баллов всех спортсменов
            Console.WriteLine("\nОбщая сумма баллов для каждого спортсмена:");
            for (int j = 0; j < scores.GetLength(1); j++)
            {
                int totalScore = 0;
                for (int i = 0; i < scores.GetLength(0); i++)
                {
                    totalScore += scores[i, j];
                }
                Console.WriteLine($"Спортсмен №{j + 1}: {totalScore}");
            }

            // Запрос номера спортсмена у пользователя
            Console.Write("\nВведите номер спортсмена (от 1 до 20), чтобы посмотреть его общую сумму баллов: ");
            int athleteNumber = int.Parse(Console.ReadLine());

            if (athleteNumber < 1 || athleteNumber > 20)
            {
                Console.WriteLine("Неверный номер спортсмена. Попробуйте снова.");
                return;
            }

            // Вывод общей суммы баллов для выбранного спортсмена
            int selectedAthleteScore = 0;
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                selectedAthleteScore += scores[i, athleteNumber - 1];
            }

            Console.WriteLine($"Общая сумма баллов спортсмена №{athleteNumber}: {selectedAthleteScore}");
        }


        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            byte numb = byte.Parse(Console.ReadLine());
            switch (numb)
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



    }
}
