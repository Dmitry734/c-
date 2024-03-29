
//Задача 34
int size;

Console.Write("Задача 34: \n");
Console.Write("Программа задает массив заполненный случайными положительными трёхзначными числами, показывает количество чётных чисел в массиве. \n");
Console.Write("Введите число элементов в массиве: ");
int.TryParse(Console.ReadLine()!, out size);

Console.Write($"Количество четных чисел в массиве = {Arr_count_even_digits(CreateArray(size, 100, 1000))} \n");
Console.Write("\n");
Console.Write("=============================\n");

//==========================================================================================================
//==========================================================================================================

//Задача 36
Console.Write("Задача 36: \n");
Console.Write("Программа, задает одномерный массив, заполненный случайными числами. Найдит сумму элементов, стоящих на нечётных позициях.\n");
Console.Write("Введите число элементов в массиве: ");
int.TryParse(Console.ReadLine()!, out size);

Console.Write($"Сумма значений чисел на нечетных позициях в массиве = {Arr_summ_values_odd_order_numbers(CreateArray(size, -100, 100))} \n");
Console.Write("\n");
Console.Write("=============================\n");

//==========================================================================================================
//==========================================================================================================

//Задача 38
Console.Write("Задача 38: \n");
Console.Write("Программа. Пользователь задает массив вещественных чисел. Програма находит разницу между максимальным и минимальным элементом массива. \n");
Console.Write("Введите число элементов в массиве: ");
int.TryParse(Console.ReadLine()!, out size);

Console.Write($"Разница между максимальным и минимальным элементом в массиве = {ArrayMaxMinValue(CreateArrayDouble(size))} \n");

Console.Write("\n");
Console.Write("=============================\n");

//==========================================================================================================
//FUNCTIONS
//==========================================================================================================

int Arr_count_even_digits(int[] _array)
{
    int counter = 0;
    foreach (var item in _array)
    {
        if (item % 2 == 0)
        { counter++; }
    }
    return counter;
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

int Arr_summ_values_odd_order_numbers(int[] _array)
{
    int summ = 0;
    for (int i = 0; i < _array.Length; i++)
    {
        if (i % 2 != 0)
        { summ += _array[i]; }
    }
    return summ;
}

double[] CreateArrayDouble(int _size)
{
    double a;
    double[] _array = new double[_size];
    for (int i = 0; i < _array.Length; i++)
    {
        Console.Write($"Введите элемент {i + 1}: ");
        double.TryParse(Console.ReadLine()!, out a);
        _array[i] = a;
    }

    Console.WriteLine();
    return _array;
}

double ArrayMaxValue(double[] _array)
{
    double max = _array[0];
    foreach (var item in _array)
    {
        if (max < item)
        { max = item; }
    }
    return max;
}
double ArrayMinValue(double[] _array)
{
    double min = _array[0];
    foreach (var item in _array)
    {
        if (min > item)
        { min = item; }
    }
    return min;
}

double ArrayMaxMinValue(double[] _array)
{
    return ArrayMaxValue(_array) - ArrayMinValue(_array);
}
