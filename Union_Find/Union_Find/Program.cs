using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Union_Find
{
    public static class Graph
    {
        public static Graph<Point> Maze1(int height, int width)
        {
            var maze = new List<HashSet<Vertex<Point>>>(width * height);

            var walls = new List<(Vertex<Point> first, Vertex<Point> second)>();
        }
    }


    class Program
    {



        static void Main(string[] args)
        {
            var maze = new List<HashSet<Vertex<Point>>>();
            
            var walls = new List<(Vertex<Point> first, Vertex<Point> second) > 
        }



        static 










        /* static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] theArray = new int[9];
            for (int i = 0; i < 9; i++)
            {
                theArray[i] = -1;
            }

            Merge(3, 4, theArray);
            Merge(5, 6, theArray);
            Merge(3, 5, theArray);
            PrintArray(theArray);
            Console.WriteLine();
            Merge(1, 3, theArray);
            PrintArray(theArray);

            Console.ReadKey();
        }

        static void Merge(int parent1, int parent2, int[] array)
        {
            if (array[parent1] >= 0 || array[parent2] >= 0)
            {
                throw new Exception("You Messed Up!");
            }

            int size1 = -array[parent1];
            int size2 = -array[parent2];

            if (size1 >= size2)
            {
                for (int i = parent2; i < parent2 + size2; i++)
                {
                    array[i] = parent1;
                }
                array[parent1] -= size2;
            }
            else
            {
                for (int i = parent1; i < parent1 + size1; i++)
                {
                    array[i] = parent2;
                }
                array[parent2] -= size1;
            }
        }
    }*/
    }
}
