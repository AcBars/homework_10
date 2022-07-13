/*
Задача 61: Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.*/


using static System.Console;
Clear();
Write("Введите число строк");
int row=int.Parse(ReadLine());

int [,] array(int size)
{
    int [,] result=new int[size+1,size+1];
    for(int i=1; i<size; i++)
    {
        for(int  j=-i; j<=i; j+=2)
        {
            result[i,j]=result[]
        }
    }
}


for(int i=0; i<row; i++)
{
    SetCursorPosition(0, i);
    Write(i+1);
    for(int j=-i; j<=i; j+=2)
    {
        SetCursorPosition(WindowWidth/2-j, i);
        Write(1);
    }
    
}
