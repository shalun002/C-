using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массивы
            //int[] array = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    array[i] = i * 10;
            //    Console.WriteLine(array[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.ReadLine();

            // двумерный массив


            //int [,] twoDimArray = new int[5, 10];
            //int[,,] threeDimArray = new int[2, 2, 2];

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        twoDimArray[i, j] = i * j;
            //        Console.Write(twoDimArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            // зубчатый массив
            Random random = new Random();    // генератор случайных чисел

            int[][] juggedArray = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                juggedArray[i] = new int[(i * 3) + 1];
                for (int j = 0; j < juggedArray[i].Length; j++)
                {
                    juggedArray[i][j] = random.Next(0, 10);
                    Console.Write(juggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
