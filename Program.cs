//Task 1 Показать натуральные числа от M до N, N и M заданы

/*

void NaturNumbrs(int M, int N)
{
    Console.Write($"{M}\t");
    if (M > N) NaturNumbrs(M - 1, N);
    else if (N > M) NaturNumbrs(M + 1, N);
}

int inputInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int M = inputInt("Enter number М:");
int N = inputInt("Enter number N:");


NaturNumbrs(M, N);

*/

//Task2  Найти сумму элементов от M до N, N и M заданы

int SumNumbers(int M, int N)
{
    if (M>N) return M + SumNumbers(M-1, N);
    else if (N>M) return M + SumNumbers(M+1, N);
    
    return M;
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int M = ReadInt("Enter number М:");
int N = ReadInt("Enter number N:");

Console.WriteLine(SumNumbers(M, N));