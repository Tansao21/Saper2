using System.Drawing;
using System;
using System.Linq.Expressions;

int[,] pole = new int [ 5, 5 ];



char saper = 'S';
char stena = 'X';
char mina = 'o';

bool minaN = false;

while (true)
{

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            pole[i, j] = '*'; // пустоа 
            pole[0, j] = stena;
            pole[i, 0] = stena;
            pole[5 - 1, j] = stena;
            pole[j, 5 - 1] = stena;// стены
          //pole[5 - 4, 5 - 4] = saper;

            if (minaN)
            {
                pole[1, 3 - 1] = mina;
                pole[2, 4 - 1] = mina;  // вывел мины
                pole[3, 4 - 3] = mina;
                pole[i, j] = '@';
            }
        }
    }


    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write((char)pole[i, j]);
        }
        Console.WriteLine();
    }

    int i1, j1;
    Console.WriteLine("Введите координаты i1: ");
    i1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координаты j1: ");
    j1 = int.Parse(Console.ReadLine());

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (i1 == i && j1 == j )
            {
                minaN = true;
                pole[1, 3 - 1] = mina;
                pole[2, 4 - 1] = mina;  // вывел мины
                pole[3, 4 - 3] = mina;
                
            }
            else if (i1 != i && j1 != j )
            {
                pole[i, j] = '@';
            }
        }

    }


}





