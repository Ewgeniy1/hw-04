using System;
using System.Globalization;

namespace hw_04
{
    internal class Arraay
    {
        static void Main(string[] args)
        {

            int temp;
            Random rand = new Random();
            int[] Array = new int[7];
            Console.WriteLine("Random array");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rand.Next(-20, 20);
                Console.WriteLine(Array[i]);
            }
            Console.WriteLine();
            int counter1 = 0;
            for (int i = 1; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    if (Array[j] > Array[j])
                    {
                        temp = Array[j + 1];
                        Array[j + 1] = Array[j];
                        Array[j] = temp;
                        counter1++;
                    }
                }
            }
            Console.WriteLine("Sorted arrays in  order");









            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);

            }
            Console.WriteLine($"Sorting of this array took{counter1}iterations");
            int t = Array.Length;
            int k = t / 2;
            int temp2;
            int counter2 = 0;
            for (int i = 0; i < k; i++)
            {
                temp2 = Array[i];
                Array[i] = Array[t - i - 1];
                Array[t - i - 1] = temp2;
                counter2++;
            }
            Console.WriteLine("Sorted array in descending order: ");
            foreach (int i in Array)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("Sorting of this array took{counter2}iterations");



        }
    }
}
