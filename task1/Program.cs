// Задайте значение N. Напишите программу,
// которая выведет все четные натуральные числа в промежутке от m до N . 
// Выполнить с помощью рекурсии.
// M, N = 5, 8 -> "6, 8"
// M, N = 2, 4 -> "2, 4"

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Проверяем верно ли введены числа
(int, int) CheckInput(int M, int N)
{
    M = Math.Abs(M);
    N = Math.Abs(N);

    if (N < M)
    {
        int temp = M;
        M = N;
        N = temp;
    }
    return (M, N);
}
void GetEvenNumbers(int M, int N)
{

    if (M == N)
    {
        if ((M % 2) == 0)
        {
            Console.Write($"{M}");
        }
    }
    else
    {
        if ((M % 2) == 0)
        {
            Console.Write($"{M}, ");
        }
        M++;
        GetEvenNumbers(M, N);
    }
}

int M = Prompt("Введите число M: ");
int N = Prompt("Введите число N: ");

(M, N) = CheckInput(M, N);

Console.WriteLine($"Все четные числа из промежутка от {M} до {N} => ");
GetEvenNumbers(M, N);
