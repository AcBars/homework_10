/*
Задача 61: Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.*/


using static System.Console;
using MyLib;

Clear();


Write("Введите число строк: ");
int row=int.Parse(ReadLine());
PythagoreanTriangle(row);








void PythagoreanTriangle(int size)
{
    size++;
    int [,] result=new int[size*2+1,size*2+1];
    result [0,size]=1;
    for(int i=1; i<size; i++)
    {
        for(int  j=-i; j<=i; j+=2)
        {
            result[i,size-j]=result[i-1,size-j-1]+result[i-1,size-j+1];
        }
    }
    for(int i=0; i<size; i++)
    {
        SetCursorPosition(0, i);
        Write(i+1);
        for(int j=-i; j<=i; j+=2)
        {
            SetCursorPosition(WindowWidth/2-j, i);
            Write(result[i,size-j]);
        }
    }
}