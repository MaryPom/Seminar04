// Задача 3. Написать программу копирования массива
Console.WriteLine("Введите длину массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(0, 100);
}
Console.WriteLine("Изначальный массив: ");
for (int i = 0; i < n; i++)
{
    Console.Write($"{array[i]} ");
}
int[] copy = new int [n];
for (int i = 0; i < n; i++)
{
    copy[i] = array[i];
}
Console.WriteLine("\nСкопированный массив: ");
for (int i = 0; i < n; i++)
{
    Console.Write($"{copy[i]} ");
}
