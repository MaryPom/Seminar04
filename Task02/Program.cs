﻿//Задача 2. Написать программу масштабирования фигуры
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

double x1 = 0;
double y1 = 0;
double x2 = 2;
double y2 = 0;
double x3 = 0;
double y3 = 2;
double x4 = 2;
double y4 = 2;
Console.Write("Введите коэффициент масштабирования k: ");
double k = double.Parse(Console.ReadLine());
Console.WriteLine($"({k*x1},{k*y1}) ({k*x2},{k*y2}) ({k*x3},{k*y3}) ({k*x4},{k*y4})");
