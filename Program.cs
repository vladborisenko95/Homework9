// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1

int InputData(string message)
{
    Console.Write(message);
    int d = int.Parse(Console.ReadLine());
    return d;
}

int AllNatur(int n)
{
    if (n > 1) return AllNatur(n - 1) + 1;
    else return 1;
}

void Print(int n)
{
    for (int i = n; i > 0; i--)
    {
        Console.Write(AllNatur(i) + " ");
    }
}

int n = InputData("Введите N ");

Print(n);

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int InputData(string msg)
{
    Console.Write(msg);
    int d = int.Parse(Console.ReadLine());
    return d;
}

int RecSum(int m, int n)
{
    if (m <= n)  return  RecSum(m, n - 1) + n;
    else return 0;
}

int m = InputData("Введите M ");
int n = InputData("Введите N ");
if (m < n) Console.WriteLine(RecSum(m, n));
else Console.WriteLine("Ошибка");

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

long InputData(string msg)
{
    Console.Write(msg);
    long d = long.Parse(Console.ReadLine());
    return d;
}

long AckermansFunction(long m, long n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermansFunction(m - 1, 1);
    else return AckermansFunction(m - 1, AckermansFunction(m, n - 1)); ;
}

long m = InputData("Введите M ");
long n = InputData("Введите N ");

if (m >= 0 && n >= 0) Console.WriteLine(AckermansFunction(m, n));
else Console.WriteLine("Ошибка");