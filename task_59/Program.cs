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
int[,] Arr =Ex.GetArray(mA, nA);
Ex.PrintArray(Arr);
WriteLine("----------------");
Ex.PrintArray(RemovMinArray(Arr));





int [,] RemovMinArray(int [,] Arr)
{
    int [] result={Arr[0,0],0,0};
    for(int i=0; i<Arr.GetLength(0); i++)
    {
        for(int j=0; j<Arr.GetLength(1); j++)
        {
            if(result[0]>Arr[i,j])
            {
                result[0]=Arr[i,j];
                result[1]=i;
                result[2]=j;
            }
        }
    }
    WriteLine($"[{String.Join(",", result)}]");
    WriteLine("---------------------");
    int [,] result_arr=new int[Arr.GetLength(0)-1,Arr.GetLength(1)-1];
    for(int i=0;i< result_arr.GetLength(0); i++)
    {
       int k = result[1]<=i ? (i+1) : (i);
        for(int j=0; j< result_arr.GetLength(1); j++)
        {
            int r = result[2]<=j ? (j+1) : (j);
            result_arr[i,j]=Arr[k,r];
        }
    }
    return result_arr;
}