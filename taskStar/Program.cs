// Найти второй максимум в массиве.
// 4, 4, 3, 0, 2 => 3

//Вводим значения для работы с массивом
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Заполняем массив
int[] GenerateArray(int numLength, int numStart, int numEnd)
{
    int[] array = new int[numLength];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(numStart, numEnd + 1);
    }
    return array;
}

//Выводим массив на экран
void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]");
}

// Получаем максимальный элемент
int GetMaxFirstElementArray(int[] array)
{
    int maxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxElement < array[i])
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}

// Получаем второй максимальный элемент массива
int GetMaxSecondElementArray(int[] array, int maxFirst)
{
    int maxElement = array[0];
    if (maxElement <= maxFirst)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if ((maxElement < array[i]) && (array[i] < maxFirst))
            {
                maxElement = array[i];
            }
        }
    }

    return maxElement;
}

int NumberLength = Prompt("Введите значение длины массива: ");

int NumberStart = Prompt("Введите начальное значение для заполнения массива: ");

int NumberEnd = Prompt("Введите конечное значение для заполнения массива: ");

int[] arrayNumbers = GenerateArray(NumberLength, NumberStart, NumberEnd);
PrintArray(arrayNumbers);
int maxFirstElement = GetMaxFirstElementArray(arrayNumbers);

int maxSecondElementArray = GetMaxSecondElementArray(arrayNumbers, maxFirstElement);
Console.WriteLine($" Второй максимальный элемент массива = {maxSecondElementArray}");
