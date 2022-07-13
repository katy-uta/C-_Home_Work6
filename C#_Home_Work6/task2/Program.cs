﻿/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/

double GetNumber(string message)
{
    double result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {
        Console.WriteLine(message);

        if (double.TryParse(Console.ReadLine(), out result))
        {
            if (result == 0)
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
            else
                break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

void GetXY(double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2)
    {
               Console.WriteLine($"Прямые параллельны параллельны друг другу, точек пересечения нет.");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 = ({x}, {y})");
    }
}
double k1 = GetNumber("Введите коэффициент k1");
double b1 = GetNumber("Введите коэффициент b1");
double k2 = GetNumber("Введите коэффициент k2");
double b2 = GetNumber("Введите коэффициент b2");

GetXY(k1, b1, k2, b2);


