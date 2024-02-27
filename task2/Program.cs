// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
int FuncAckermann(int m, int n)
{
    if (m > 0 && n > 0) return FuncAckermann(m - 1, FuncAckermann(m, n - 1));
    if (m > 0 && n == 0) return FuncAckermann(m - 1, 1);
    else return n + 1;
}

Console.WriteLine($"Введите число m");
int firstnum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число n");
int secondnum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана равно {FuncAckermann(firstnum, secondnum)}");