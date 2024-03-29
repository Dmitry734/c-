
//Задача 25
int a, b;

Console.Write("Задача 25: \n");
Console.Write("Программа, В которой есть функция, используя цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. \n");
Console.Write("Введите число А: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите число B: ");
int.TryParse(Console.ReadLine()!, out b);
if (b > 0)
{ Console.Write($"A в степени B = {NewPow(a, b)}\n"); }
else
{ Console.Write($"B не является натуральной степенью \n"); }
Console.Write("=============================\n");

long NewPow(int base_digit, int degree)
{
    long answer = base_digit;
    if (degree > 1)
    {
        for (int i = 2; i <= degree; i++)
        {
            answer *= base_digit;
        }
    }
    return answer;
    //return (long)Math.Pow(base_digit, degree);
}



//==========================================================================================================
//==========================================================================================================

//Задача 27
Console.Write("Задача 27: \n");
Console.Write("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.\n");

Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out a);


Console.Write($"сумма цифр в числе. = {SumInDigitSimbols(a)}\n");
Console.Write("=============================\n");

int SumInDigitSimbols(int a)
{
    int divider = 10;
    int sum = 0;

    while (a / divider > 0)
    {
        sum += a % divider;
        a = a / divider;
    }
    return sum += a % divider;
}

//==========================================================================================================
//==========================================================================================================

//Задача 29
Console.Write("Задача 29: \n");
Console.Write("Программа, которая задаёт массив из 8 элементов и выводит их на экран (использую функцию). \n");

Output_Array(CreateArray(8));

void Output_Array(int[] _array)
{
    foreach (var item in _array)
    { Console.Write($"{item} "); }
}

int[] CreateArray(int _size)
{
    int a;
    int[] _array = new int[_size];
    for (int i = 0; i < _array.Length; i++)
    {
        Console.Write($"Введите элемент {i + 1}: ");
        int.TryParse(Console.ReadLine()!, out a);
        _array[i] = a;
        //_array[i] = new Random().Next(10); 
    }
    return _array;
}
Console.Write("\n");
Console.Write("=============================\n");

//==========================================================================================================
//==========================================================================================================
