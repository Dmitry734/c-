//Задача 64
int n;
int m;

Console.Write("Задача 64: \n");
Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");

Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

n = 0;
while (n <= 0)
{
    Console.Write("Введите значение N (целое, >0): ");
    int.TryParse(Console.ReadLine()!, out n);
    if (n <= 0)
    { Console.WriteLine("Требуется ввести верные значения"); }
}
Console.WriteLine("=        =       =       =       =  ");

Console.WriteLine("");
Console.WriteLine("===== Результат ========");
Console.WriteLine("");

Console.WriteLine($"{PrintNumbers(1, n)}");

Console.Write("\n");
Console.Write("=============================\n");
Console.WriteLine("");
Console.Write("НАЖМИТЕ 'ENTER' ДЛЯ ПЕРЕХОДА К СЛЕДУЮЩЕЙ ЗАДАЧЕ");
Console.ReadLine();
Console.WriteLine("");

//==========================================================================================================
//==========================================================================================================

//Задача 66
Console.Write("Задача 66: \n");
Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

m = 0;
while (m <= 0)
{
    Console.Write("Введите значение M (целое, >0): ");
    int.TryParse(Console.ReadLine()!, out m);
    if (m <= 0)
    { Console.WriteLine("Требуется ввести верные значения"); }
}
n = 0;
while (n <= 0)
{
    Console.Write("Введите значение N (целое, >0): ");
    int.TryParse(Console.ReadLine()!, out n);
    if (n <= 0)
    { Console.WriteLine("Требуется ввести верные значения"); }
}
Console.WriteLine("=        =       =       =       =  ");

Console.WriteLine("");
Console.WriteLine("===== Результат ========");
Console.WriteLine("");

Console.WriteLine($"{SummAllNumbersBetweenNumbers(m, n)}");

Console.Write("\n");
Console.Write("=============================\n");
Console.WriteLine("");
Console.Write("НАЖМИТЕ 'ENTER' ДЛЯ ПЕРЕХОДА К СЛЕДУЮЩЕЙ ЗАДАЧЕ");
Console.ReadLine();
Console.WriteLine("");
//==========================================================================================================
//==========================================================================================================

//Задача 68
Console.Write("Задача 68: \n");
Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");

Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

m = 0;
while (m <= 0)
{
    Console.Write("Введите значение M (целое, >0): ");
    int.TryParse(Console.ReadLine()!, out m);
    if (m <= 0)
    { Console.WriteLine("Требуется ввести верные значения"); }
}
n = 0;
while (n <= 0)
{
    Console.Write("Введите значение N (целое, >0): ");
    int.TryParse(Console.ReadLine()!, out n);
    if (n <= 0)
    { Console.WriteLine("Требуется ввести верные значения"); }
}
Console.WriteLine("=        =       =       =       =  ");

Console.WriteLine("");
Console.WriteLine("===== Результат ========");
Console.WriteLine("");

Console.WriteLine($"{A(m, n)}");

Console.Write("\n");
Console.Write("=============================\n");
Console.WriteLine("");
Console.Write("ЭТО ПОСЛЕДНЯЯ ЗАДАЧА, НАЖМИТЕ 'ENTER'");
Console.ReadLine();
Console.WriteLine("");


//==========================================================================================================
//FUNCTIONS
//==========================================================================================================
string PrintNumbers(int _start, int _end)
{
    if (_start == _end)
    {
        return _end.ToString();
    }
    else
    {
        return $"{PrintNumbers(_start + 1, _end)} {_start}";
    }
}

int SummAllNumbersBetweenNumbers(int _start, int _end)
{
    if (_start == _end)
    {
        return _end;
    }
    else
    {
        return _start + SummAllNumbersBetweenNumbers(_start + 1, _end);
    }
}



int A(int _n, int _m)
{
    if (_n == 0) return _m + 1;
    if (_n != 0 && _m == 0) return A(_n - 1, 1);
    if (_n > 0 && _m > 0) return A(_n - 1, A(_n, _m - 1));
    return A(n, m);

}

int[] CreateArray(int _size, int min, int max)
{
    int[] _array = new int[_size];
    for (int i = 0; i < _array.Length; i++)
    {
        _array[i] = new Random().Next(min, max);
        Console.Write($"{_array[i]}     ");
    }
    Console.WriteLine();
    return _array;
}