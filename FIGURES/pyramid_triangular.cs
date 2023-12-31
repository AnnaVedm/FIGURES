﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FIGURES
{
    class PyramidTriangular : Triangle // треугольная пирамида
    {
        private double H; // высота конуса (отрезок от вершины конуса до центра его основания)
        private double volume; // объем фигуры

        public PyramidTriangular(double a, double b, double area, double perimeter) : base(a, b, area, perimeter) { } // связь с род. классом

        public void Input() // ввод
        {
            Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ, ОБЪЕМА И ПЕРИМЕТРА ТРЕУГОЛЬНОЙ ПИРАМИДЫ");
            Console.Write("\nВведите ребро основания пирамиды: ");
            a = Convert.ToSingle(Console.ReadLine());

            if (a <= 0)
            {
                a = Checking(a); // вызов проверки введенного значения
            } 

            Console.Write("Введите боковое ребро пирамиды: ");
            b = Convert.ToSingle(Console.ReadLine());

            if (b <= 0) 
            { 
                b = Checking(b); 
            }
            Console.Write("Введите высоту пирамиды (отрезок от вершины пирамиды до центра его основания): ");
            H = Convert.ToSingle(Console.ReadLine());

            if (H <= 0) 
            { 
                H = Checking(H); 
            }

            Area();
            Perimeter();
            Volume();
            Output(area, perimeter, volume);
        }

        private void Area() // площадь
        {
            area = Math.Round(Math.Sqrt(3) / 4 * Math.Pow(a, 2) + 3 / 2 * a * Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a, 2) / 4), 3);
        }

        private void Perimeter() // периметр
        {
            perimeter = Math.Round(3 * a + 3 * (a + b + b), 3);
        }

        private void Volume() // объем
        {
            volume = Math.Round(((Math.Pow(a, 2) * Math.Sqrt(3)) / 4 * H) / 3, 3);
        }

        private void Output(double area, double perimeter, double volume) // вывод
        {
            Console.Write($"\nОбъем фигуры: {volume}");
            base.Output(area, perimeter); // вызывается из род. класса по умолчанию
        }
    }
}
