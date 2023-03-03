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

/*

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

*/

//Task 3 Найти сумму цифр числа

/*


int SumOfNumbers(int number)
{
    if (number == 0) return 0;
    return SumOfNumbers(number/10) + number % 10; 
}

Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(SumOfNumbers(number));

*/


//Task4 Написать программу вычисления функции Аккермана

/*
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;

  else if (n == 0) return Ack(m - 1, 1);

  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  
  return output;
}

*/
//Task 5 Написать программу возведения числа А в целую стень B

/*

int raisingToIntegerPower(int a, int b)
{
    if (b > 0) return a * raisingToIntegerPower(a, b - 1);
    if (b < 0) return a * raisingToIntegerPower(a, b + 1);
    if (b == 0) return 1;
    return 1;
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int a = ReadInt("Введите число A:");
int b = ReadInt("Введите число B:");

double result = Convert.ToDouble(raisingToIntegerPower(a, b));

if (b < 0) result = Math.Round(1 / result, 3);
Console.WriteLine($"Результат: {result}");

*/


//Task6 Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

/*

int[] SequenceSum(int a, int b, int n)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;

    for (int i = 3; i <= array.Length; i++)
        array[i-1] = array[i-2] + array[i-3];
    
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

        Console.Write($"{array[i]}\t");
}

int ReadInt(string message)
{
    Console.WriteLine(message);

    return int.Parse(Console.ReadLine());
}

int a = ReadInt("Введите число A:");
int b = ReadInt("Введите число B:");
int n = ReadInt("Сколько чисел вывести?");

PrintArray(SequenceSum(a, b, n));

*/