using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int q = 0;
        static int g = 0;
        static int i = 0;
        static int j = 0;
        //static int sz = 1;
        static int[] tomb = new int[10];
        static Random ran = new Random();

        static void Main(string[] args)
        {
            for (; ; )
            {
                gen();
                sort();
            }
        }



        static void gen()
        {
            for (q = 0; q < 10; q++)
            {
                tomb[q] = ran.Next(0, 50);
            }
            for (int a = 0; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    if (a != b)
                    {
                        if (tomb[a] == tomb[b])
                        {
                            tomb[b] = ran.Next(0, 50);
                            b--;
                        }
                    }
                }
            }



                for (int z = 0; z < 10; z++)
                {
                    Console.Write(tomb[z] + ", ");
                }
            Console.WriteLine();

        }




        static void sort()
        {
            for (i = 0; i < 10; i++)
            {




                for (j = i + 1; j < 10; j++)
                {





                    if (tomb[i] > tomb[j])
                    {
                        int temp = tomb[j];
                        tomb[j] = tomb[i];
                        tomb[i] = temp;
                    }
                }
            }


            for (int z = 0; z < 10; z++)
            {
                Console.Write(tomb[z] + ", ");
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
