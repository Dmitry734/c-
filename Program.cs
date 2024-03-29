
//Задача 54
int n, m, k;
int[,] arr;

Console.Write("Задача 54: \n");
Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

Console.WriteLine("Введите размерность массива MxN:");
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
arr = Array_Create_int_two_demensions(m, n, -100, 100);
Console.WriteLine("");



Console.WriteLine("");
Console.WriteLine("===== Результат ========");
Console.WriteLine("");
Array_int_Sort_in_one_of_two_demensions(ref arr);
Array_Int_Two_Demesion_Output(ref arr);

Console.Write("\n");
Console.Write("=============================\n");
Console.WriteLine("");
Console.Write("НАЖМИТЕ ДЛЯ ПЕРЕХОДА К СЛЕДУЮЩЕЙ ЗАДАЧЕ");
Console.ReadLine();
Console.WriteLine("");
//==========================================================================================================
//==========================================================================================================

//Задача 56
Console.Write("Задача 56: \n");
Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

Console.WriteLine("Введите размерность массива MxN:");
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

arr = Array_Create_int_two_demensions(m, n, -100, 100);
Console.WriteLine("");



Console.WriteLine("");
Console.WriteLine("===== Результат ========");
Console.WriteLine("");
Console.WriteLine($"Cтрока с наименьшей суммой элементов (нумерация строк начинается с 1): {Array_Two_Demensions_Min_Sum_Row(arr) + 1}");
//Array_Int_Two_Demesion_Output(ref arr);

Console.Write("\n");
Console.Write("=============================\n");
Console.WriteLine("");
Console.Write("НАЖМИТЕ ДЛЯ ПЕРЕХОДА К СЛЕДУЮЩЕЙ ЗАДАЧЕ");
Console.ReadLine();
Console.WriteLine("");

//==========================================================================================================
//==========================================================================================================

//Задача 58
Console.Write("Задача 58: \n");
Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

Console.WriteLine("Введите размерность (на ее основе будут сформированны 2 массива)первого массива 1)MxN и 2)NxM");
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
int[,] arr1 = Array_Create_int_two_demensions(m, n, 0, 5);
Console.WriteLine("");
Console.WriteLine($"Сгенерированный массив размерностью {n}x{m}:");
Console.WriteLine("");
int[,] arr2 = Array_Create_int_two_demensions(n, m, 0, 5);
Console.WriteLine("");
Console.WriteLine("=        =       =       =       =  ");


Console.WriteLine("======== Результат ========");
Console.WriteLine("");

arr = Array_Сomposition_Matrix(arr1, arr2);
Array_Int_Two_Demesion_Output(ref arr);


Console.Write("\n");
Console.Write("=============================\n");

Console.WriteLine("");
Console.Write("НАЖМИТЕ ДЛЯ ПЕРЕХОДА К СЛЕДУЮЩЕЙ ЗАДАЧЕ");
Console.ReadLine();
Console.WriteLine("");

//==========================================================================================================
//==========================================================================================================

//Задача 60
Console.Write("Задача 60: \n");
Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

Console.WriteLine("Введите размерность (на ее основе будут сформированны 2 массива)первого массива 1)MxN и 2)NxM");
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
k = 0;
while (k <= 0)
{
    Console.Write("Введите значение K (целое, >0): ");
    int.TryParse(Console.ReadLine()!, out k);
    if (k <= 0)
    { Console.WriteLine("Требуется ввести верные значения"); }
}
Console.WriteLine("=        =       =       =       =  ");
Console.WriteLine("");
Console.WriteLine($"Сгенерированный массив размерностью {m}x{n}x{k}:");
Console.WriteLine("");
int[,,] arr3 = Array_Create_int_three_demensions(m, n, k, 0, 10);
Console.Write("\n");
Console.Write("=============================\n");

Console.WriteLine("");
Console.Write("НАЖМИТЕ ДЛЯ ПЕРЕХОДА К СЛЕДУЮЩЕЙ ЗАДАЧЕ");
Console.ReadLine();
Console.WriteLine("");

//==========================================================================================================
//==========================================================================================================

//Задача 62
Console.Write("Задача 62: \n");
Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4.");
Console.WriteLine("");
Console.WriteLine("===== Введите значения ========");
Console.WriteLine("");

Console.WriteLine("Введите размерность массива MxM:");
m = 0;
while (m <= 0)
{
    Console.Write("Введите значение M (целое, >0): ");
    int.TryParse(Console.ReadLine()!, out m);
    if (m <= 0)
    { Console.WriteLine("Требуется ввести верные значения"); }
}

Console.WriteLine("=        =       =       =       =  ");

Console.WriteLine("");
Console.WriteLine("===== Результат ========");
Console.WriteLine("");


Console.WriteLine("");
Console.WriteLine($"Сгенерированный массив размерностью {m}x{m}:");
Console.WriteLine("");
arr = Array_Create_int_two_demensions_Type_Spiral(m, m, 0, 10);
Console.WriteLine("");

Array_Int_Two_Demesion_Output(ref arr);

Console.Write("\n");
Console.Write("=============================\n");
Console.WriteLine("");
Console.Write("ЭТО ПОСЛЕДНЯЯ ЗАДАЧА");
Console.ReadLine();
Console.WriteLine("");

//==========================================================================================================
//FUNCTIONS
//==========================================================================================================
int[,] Array_Сomposition_Matrix(int[,] _array1, int[,] _array2)
{
    int[,] _array = new int[_array1.GetLength(0), _array2.GetLength(1)];
    for (int i = 0; i < _array1.GetLength(0); i++)
    {
        for (int j = 0; j < _array2.GetLength(1); j++)
        {
            for (int k = 0; k < _array1.GetLength(1); k++)
            {
                _array[i, j] += _array1[i, k] * _array2[k, j];
            }
            //Console.Write($"{_array[i, j]}   ");
        }
        //Console.WriteLine();
    }
    return _array;
}

int[,] Array_Create_int_two_demensions_Type_Spiral(int _m, int _n, int _min, int _max)
{
    int[,] _array = new int[_m, _n];

    for (int i = 0, j = 0, t = 0; t < _array.Length; t++)
    {
        _array[i, j] = t + 1;
        //Console.Write($"{_array[i, j]} : ({i}; {j})  ");
        if (i <= (j + 1) && (i + j) < (_array.GetLength(1) - 1))
        {
            j++;
            //Console.WriteLine($"j++, j:{j}");
        }
        else if (i < j && (i + j) >= (_array.GetLength(0) - 1))
        {
            i++;
            //Console.WriteLine("j++");
        }
        else if (i >= j && (i + j) > (_array.GetLength(1) - 1))
        {
            j--;
            // Console.WriteLine("j--");
        }
        else
        {

            //Console.WriteLine("i--");
            //Console.WriteLine($"{i}<{j} ; {(i + j)} < {_array.GetLength(0) - 1}");
            i--;
        }
    }
    return _array;
}

int[,] Array_Create_int_two_demensions(int _m, int _n, int _min, int _max)
{
    int[,] _array = new int[_m, _n];

    for (int i = 0; i < _m; i++)
    {
        for (int j = 0; j < _n; j++)
        {
            _array[i, j] = new Random().Next(_min, _max);

            Console.Write($"{_array[i, j]}   ");
        }
        Console.WriteLine();
    }
    return _array;
}

int[,,] Array_Create_int_three_demensions(int _n, int _m, int _k, int _min, int _max)
{
    int[,,] _array = new int[_n, _m, _k];
    for (int i = 0; i < _n; i++)
    {
        for (int j = 0; j < _m; j++)
        {
            for (int kk = 0; kk < _k; kk++)
            {
                _array[i, j, kk] = new Random().Next(_min, _max);
                //
                Console.Write($"{_array[i, j, kk]} ({i},{j},{kk})   ");
            }
            Console.WriteLine();
        }
    }
    return _array;
}

void Array_int_Sort_in_one_of_two_demensions(ref int[,] _array)
{
    int new_j;
    Transfer_Struct bufer = new Transfer_Struct(); //переменная в которую будем запоминать

    for (int i = 0; i < _array.GetLongLength(0); i++)
    {
        //Найдем наиибольшую позицию и отправим ее в начало ряда, new_j - новая точка старта сортировки
        for (new_j = 0; new_j < _array.GetLength(1); new_j++)
        {
            bufer.mem_value = _array[i, new_j];
            bufer.answer = false; //будем менять значение 
            //Найдем наибольшую позицию
            for (int j = new_j + 1; j < _array.GetLength(1); j++)
            {
                if (_array[i, j] > _array[i, new_j])
                {
                    _array[i, new_j] = _array[i, j];
                    bufer.j = j;
                    bufer.answer = true; //флаг показывает что находили в куске ряда более большой элемент
                }
            }

            if (bufer.answer)
            {
                _array[i, bufer.j] = bufer.mem_value;//запись в то место где был максимальный элемент начало куска ряда
            }

        }
    }
}

int Array_Two_Demensions_Min_Sum_Row(int[,] _array)
{
    int[] summ_arr = new int[_array.GetLongLength(0)];
    int summ;
    for (int i = 0; i < _array.GetLongLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < _array.GetLongLength(1); j++)
        {
            summ += _array[i, j];
        }
        summ_arr[i] = summ;
    }
    return ArrayMinValuePosition(summ_arr);
}


void Array_Int_Two_Demesion_Output(ref int[,] _array)
{
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            //Console.Write($"{_array[i, j]}   ");
            Console.Write(string.Format("{0:D2} ", _array[i, j]));
        }
        Console.WriteLine();
    }

}


int ArrayMinValuePosition(int[] _array)
{
    int min = _array[0];
    int mem = 0;
    if (_array.Length > 1)
    {
        for (int i = 1; i < _array.Length; i++)
        {
            if (min > _array[i])
            {
                min = _array[i];
                mem = i;
            }
        }
    }
    return mem;

}

//==========================================================================================================
//DEFENITIONS
//==========================================================================================================

public struct Transfer_Struct
{
    public int i; // 4 bytes
    public int j; // 4 bytes
    public int mem_value;
    public int mem_value2;
    public int new_j;
    public bool answer;
}