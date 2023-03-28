// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

// Получить  сумму чисел в промежутке  [M,N]
int GetSumMToN(int m, int n)
{
    int sum = 0;
    if (m == n)
    {
        return 0;
    }
    else
    {
        m++;
        sum = m + GetSumMToN(m,n);
        return sum;
    }
}



int M = Prompt("Введите число M: ");
int N = Prompt("Введите число N: ");

(M, N) = CheckInput(M, N);

Console.WriteLine($"Сумма чисел от {M} до {N} = {GetSumMToN((M-1),N)}");