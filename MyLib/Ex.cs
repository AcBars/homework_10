namespace MyLib;
using System;
using static System.Console;
public class Ex
{
    public static int [,] GetArray (int m, int n)
    {
        int [,] result=new int [m, n];
        for(int i=0; i<m; i++)
        {
            for(int j=0; j<n; j++)
            {
                result[i,j]=new Random().Next(-100,101);
            }
        }
    return result;
    }

    public static int [,] GetArray (int m, int n, int minValue, int maxValue)
    {
        int [,] result=new int [m, n];
        for(int i=0; i<m; i++)
        {
            for(int j=0; j<n; j++)
            {
                result[i,j]=new Random().Next(minValue,maxValue);
            }
        }
    return result;
    }

    public static void PrintArray (int [,] result)
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Write($"{result[i, j]} \t ");
            }
            WriteLine();
        }
    }

    public static void PrintArray (double [] result)
    {
        for (int i = 0; i < result.Length; i++)
        {

            Write($"{result[i]} \t ");
            WriteLine();
        }
    }

    public static int FainMinNubers(int [,] array)
    {
        int result=array[0,0];
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                result=result>array[i,j]? array[i,j]: result+0;
            }
        }
        return result;
    }


        public static int [] FainIndexMinNubers(int [,] array)
    {
        int [] result={array[0,0],0,0};
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                if(result>array[i,j])
                {
                    result[0]=array[i,j];
                    result[i]=i;
                    result[j]=j;
                }
            }
        }
        return result;
    }


}


