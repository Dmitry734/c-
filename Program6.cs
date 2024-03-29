
//Задача 34
int M;
double k1, k2, b1, b2;

//==========================================================================================================
//==========================================================================================================

//Задача 41
Console.Write("Задача 41: \n");
Console.Write("Пользователь вводит с клавиатуры M чисел. Программа считает, сколько чисел больше 0 ввёл пользователь. \n");

Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

Console.Write("Введите количество чисел для последующего ввода: ");
int.TryParse(Console.ReadLine()!, out M);

Console.Write($"Столько чисел больше 0 ввёл пользователь: {Arr_count_digits_above_zero(CreateArray_by_input(M))} \n");

Console.Write("\n");
Console.Write("=============================\n");

//==========================================================================================================
//==========================================================================================================

//Задача 43
Console.Write("Задача 43: \n");
Console.WriteLine("Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");
Console.Write("Значения b1, k1, b2 и k2 задаются пользователем\n");

Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

Console.Write("Введите значение b1: ");
double.TryParse(Console.ReadLine()!, out b1);
Console.Write("Введите значение k1: ");
double.TryParse(Console.ReadLine()!, out k1);
Console.Write("Введите значение b2: ");
double.TryParse(Console.ReadLine()!, out b2);
Console.Write("Введите значение k2: ");
double.TryParse(Console.ReadLine()!, out k2);

Console.WriteLine("");
Console.WriteLine("===== Результат ========");
Console.WriteLine("");
if (k2 != k1)
{
    double x = Math.Round((b1 - b2) / (k2 - k1), 2);
    double y = k1 * x + b1;
    Console.Write($"координаты точки [x;y] пересечения двух прямых, заданных уравнениями = [{x} ; {y}]\n");
}
else
{
    if (b2 != b1)
    { Console.Write("Прямые не пересеаются \n"); }
    else
    { Console.Write("Прямые совпадают и пересекаются в бесконечном множестве точек \n"); }
}
Console.Write("\n");
Console.Write("=============================\n");


//==========================================================================================================
//FUNCTIONS
//==========================================================================================================
int Arr_count_digits_above_zero(int[] _array)
{
    int counter = 0;
    foreach (var item in _array)
    {
        if (item > 0)
        { counter++; }
    }
    return counter;
}

int[] CreateArray_by_input(int _size)
{
    int a;
    int[] _array = new int[_size];
    for (int i = 0; i < _array.Length; i++)
    {
        Console.Write($"Введите элемент {i + 1}: ");
        int.TryParse(Console.ReadLine()!, out a);
        _array[i] = a;
    }

    Console.WriteLine();
    return _array;
}
