/*
Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
*/

using static System.Console;
using MyLib;
using System.Linq;

Clear();
WriteLine("Введите размер матрицы А через пробел: ");
string[] sizeA = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int mA = int.Parse(sizeA[0]);
int nA = int.Parse(sizeA[1]);
int[,] array_A =Ex.GetArray(mA, nA);
Ex.PrintArray(array_A);
int [] CoordinMinNumbers=Ex.FainMinNubers(array_A);

int [,] NewArray(int [,] array)
{
    int [,] result=
}
