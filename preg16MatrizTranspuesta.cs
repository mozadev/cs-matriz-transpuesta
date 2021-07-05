using System;
using System.Collections;
using System.Collections.Generic;

namespace ensenanza
{
    class Program
    {

        static void Main(string[] args)
        {

            int[,] matriz = new int[3,3];
        
            // llenar matriz
            for (int i = 0; i < 3; i++) //(i,j)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("ingrese el valor del arreglo [" + i + "][" + j + "]");
                    int valor = int.Parse(Console.ReadLine());
                    matriz[i,j] = valor;
                    

                }

            }

            //3    5   6     3  4    5    
            //4    7   0     5  7   2
            //5    2   1     6  0   1

            // imprimir matriz
            for (int i = 0; i < 3; i++) //(i,j)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                    Console.Write(matriz[i, j] + " ");

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            // matriz transpuesta
            for (int i = 0; i < 3; i++) //(i,j)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(matriz[j, i] + " ");

                }
                Console.WriteLine("");
            }



        }

    }
}