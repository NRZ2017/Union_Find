using System;

namespace Union_Find
{
    class Program
    {
        static void PrintArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Main(string[] args)
        { 
            int[] theArray = new int[9];
            for(int i = 0; i < 9; i++)
            {
                theArray[i] = -1;
            }

            Merge(3, theArray);
            Console.ReadKey();
        }

         static void Merge<T>(int parent1, int parent2, T[] array)
        {

        }
        private void Merge<T>(int parent1, int parent2, T[] array)
        {
            
        }
    }
}
