// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
void PrintNumbers(int m, int n)
{
    m += 1;
    if (m < n)
    {
        Console.Write($"{m} ");
        PrintNumbers(m, n);
    }
    else
    {
        return;
    }

}

Console.WriteLine($"Введите нижнюю границу натуральное число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите верхнюю границу натуральное число n");
int n = Convert.ToInt32(Console.ReadLine());
if (m == n)
{
    Console.WriteLine($"Задан пустой интервал");
}
else
{
    PrintNumbers(m, n);
}