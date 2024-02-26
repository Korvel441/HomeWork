// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
void PrintArray(int[] numbers, int m)
{
    m -= 1;
    if (m >= 0)
    {
        Console.Write($"{numbers[m]} ");
        PrintArray(numbers, m);
    }
    else
    {
        return;
    }
}
int [] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Задайте {i} элемент массива натуральное число");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}
Console.WriteLine($"Задайте размер массива натуральное число size != 0");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = GetArray(size);
PrintArray(numbers, size);