string[] FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива :\t");
        array[i] = Console.ReadLine();
        while (array[i] == string.Empty)
        {
            Console.Write($"Вы не ввели элемент массива! ");
            Console.Write($"ВВЕДИТЕ элемент массива :\t");
            array[i] = Console.ReadLine();
        }
        Console.WriteLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write($"[\"{String.Join("\", \"", array)}\"]");
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
FillArray(array);
PrintArray(array);