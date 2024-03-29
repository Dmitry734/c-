
//Задача 47
int n, m;

Console.Write("Задача 47: \n");
Console.WriteLine("Программа, которая задает двумерный массив размером MxN, заполненный случайными вещественными числами.");

Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

Console.WriteLine("Введите размерность массива MxN");
Console.Write("Введите значение M: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Введите значение N: ");
int.TryParse(Console.ReadLine()!, out n);


Console.WriteLine("");
Console.WriteLine("===== Результат ========");
Console.WriteLine("");
double[,] array = Create_double_Array_two_demension(m, n, -1000, 1000);

Console.Write("\n");
Console.Write("=============================\n");
//==========================================================================================================
//==========================================================================================================

//Задача 50
int E_value;
Console.Write("Задача 50: \n");
Console.WriteLine("Программа, которая на вход принимает значение элемента находящегося в двумерном массиве, и возвращает позиции этого элемента или же указание того, что такого элемента нет.");

Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

Console.WriteLine("Введите размерность массива MxN");
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
Console.WriteLine("");
Console.WriteLine($"Сгенерированный массив размерностью {m}x{n}:");
int[,] arr = Create_int_Array_two_demension(m, n, -100, 100);
Console.WriteLine("");


Console.Write("Введите значение элемента - программа выведет позицию элемента в массиве: ");
int.TryParse(Console.ReadLine()!, out E_value);

Console.WriteLine("");
Console.WriteLine("===== Результат ========");
Console.WriteLine();

Transer_Struct buffer = Array_Two_Demension_Get_Position_By_Value(arr, E_value);
if (buffer.answer)
{
    Console.Write($"Позиция [i,j] элемента в массиве: [{buffer.i};{buffer.j}] ");
}
else
{
    Console.Write($"Заданное значение отсутствует в массиве");
}

Console.WriteLine("\n");
Console.WriteLine("=============================\n");


//==========================================================================================================
//==========================================================================================================

//Задача 52
Console.Write("Задача 52: \n");
Console.WriteLine("Программа, задает двумерный массив размером MxN из целых чисел. Находит среднее арифметическое элементов в каждом столбце.");

Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

Console.WriteLine("Введите размерность массива MxN");
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
Console.WriteLine($"Сгенерированный массив размерностью {m}x{n}:");
Console.WriteLine("");
arr = Create_int_Array_two_demension(m, n, -100, 100);
Console.WriteLine("");



Console.WriteLine("======== Результат ========");
//Console.WriteLine("");
//double[,] array = Create_double_Array_two_demension(m, n, -1000, 1000);
List<int> list_sum_coumns = Array_Two_Demension_Summ_In_Columns(arr);
for (int i = 0; i < n; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"Сумма значений колонки {i + 1} массива = {list_sum_coumns[i]}");
}


Console.Write("\n");
Console.Write("=============================\n");



//==========================================================================================================
//FUNCTIONS
//==========================================================================================================
double[,] Create_double_Array_two_demension(int _m, int _n, int _min, int _max)
{
    double[,] _array = new double[_m, _n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            _array[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(_min, _max), 2);
            Console.Write($"{_array[i, j]}   ");
        }
        Console.WriteLine();
    }
    return _array;
}

int[,] Create_int_Array_two_demension(int _m, int _n, int _min, int _max)
{
    int[,] _array = new int[_m, _n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            _array[i, j] = new Random().Next(_min, _max);
            Console.Write($"{_array[i, j]}   ");
        }
        Console.WriteLine();
    }
    return _array;
}

Transer_Struct Array_Two_Demension_Get_Position_By_Value(int[,] _array, int _target)
{
    Transer_Struct _transfer = new Transer_Struct();
    for (int i = 0; i < _array.GetLongLength(0); i++)
    {
        for (int j = 0; j < _array.GetLongLength(1); j++)
        {
            if (_array[i, j] == _target)
            {
                _transfer.i = i + 1;
                _transfer.j = j + 1;
                _transfer.answer = true;
                return _transfer;
            }
        }
    }
    _transfer.answer = false;
    return _transfer;
}

List<int> Array_Two_Demension_Summ_In_Columns(int[,] _array)
{
    List<int> _list_sum_coumns = new List<int>();
    int summ;
    for (int j = 0; j < _array.GetLongLength(1); j++)
    {
        summ = 0;
        for (int i = 0; i < _array.GetLongLength(0); i++)
        {
            summ += _array[i, j];
        }
        _list_sum_coumns.Add(summ);
    }
    return _list_sum_coumns;
}

//==========================================================================================================
//DEFENITIONS
//==========================================================================================================

public struct Transer_Struct
{
    public int i; // 4 bytes
    public int j; // 4 bytes
    public bool answer;
}