﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SummCompare sc = new SummCompare();
                ABSCompare ac = new ABSCompare();
                int[][] vektor = new int[4][];
                vektor[0] = new[] { 1, 8, 3 };
                vektor[1] = new[] { 1, 2, 3 };
                vektor[2] = new[] { 1, 2,3 };
                vektor[3] = new[] { 1, 1, 1, -52 };
                JaggedArraySot.JaggrtArraySort.Sort(vektor, sc);
                PrintArray(vektor);
                JaggedArraySot.JaggrtArraySort.Sort(vektor, ac);
                PrintArray(vektor); 
            }
            catch (NullReferenceException NRE)
            {
                Console.WriteLine(NRE.Message);
            }
                       
        }

        private static void PrintArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                foreach (int j in arr[i])
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
