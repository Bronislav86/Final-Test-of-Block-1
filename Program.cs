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

void PrintShortArray(string[] array, int symbolsPerItem)
{
    string[] shortArray = new string[array.Length];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= symbolsPerItem)
        {
            shortArray[j++] = array[i];
        }
    }
    Array.Resize(ref shortArray, j);

    Console.Write($"[\"{String.Join("\", \"", shortArray)}\"]");
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
int symbolsPerItem = 3;
FillArray(array);
PrintArray(array);
PrintShortArray(array, symbolsPerItem);