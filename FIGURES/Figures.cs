﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURES
{
    class Figures // родительский класс
    {
        protected double a; // сторона фигуры
        protected double area; // площадь
        protected double perimeter; // периметр

        protected Figures(double a, double area, double perimeter)
        {
            this.a = a;
            this.area = area;
            this.perimeter = perimeter;
        }

        protected virtual void Output(double area, double perimeter) // вывод по умолчанию
        {
            Console.WriteLine($"\nПлощадь фигуры: {area}");
            Console.WriteLine($"Периметр фигуры: {perimeter}");
            Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadKey();
        }

        protected virtual double Checking(double a) // проверка на то, чтобы введенные данные были больше нуля
        {
            while (a <= 0)
            {
                Console.Write("ОШИБКА: Введенное значение должно быть больше нуля.\nПопробуйте ввести значение заново: ");
                a = double.Parse(Console.ReadLine());
            }
            return a; // возвращение измененного значения
        }
    }
}
