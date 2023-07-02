using System;
using System.Runtime.CompilerServices;

namespace Extansions
{
    enum Directions
    {
        ToUpper = 0, ToLower = 1,
    }
    static class Extansions
    {
        static public void SortArr(this int[] arr, Directions direction) 
        {
            int temp = default;
            if (direction == Directions.ToUpper)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
        }

        static public bool Find(this int[] arr, int num)
        {
            foreach(int i in arr)
            {
                if(i == num)
                    return true;
            }
            return false;
        }

        static public bool Find(this int[] arr, params int[] valuesToFind)
        {
            
            foreach (int i in arr)
            {
                foreach (int j in valuesToFind)
                {
                    if (i == j)
                        return true;
                }
                
            }
            return false;
        }

        static public int[] Plus(this int[]arr,params int[] otherArr)
        {
            int[] mergedArray = arr.Concat(otherArr).ToArray();
            return mergedArray;
        }

        static public int[] Get(this int[] array, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (int element in array)
            {
                if (predicate(element))
                {
                    result.Add(element);
                }
            }

            return result.ToArray();
        }
    }



    class Program
    {



        static void Main()
        {
            int[] arr = { 5, 1, 3, 4, 8, 6, 7 };
            int[] arr2 = { 10, 11, 12, 40, 80, 60, 70 };
            //1
            //arr.SortArr(Directions.ToLower);
            //Console.WriteLine("To Lower");
            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //arr.SortArr(Directions.ToUpper);
            //Console.WriteLine("To Upper");
            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");
            //}

            // 2
            //Console.WriteLine(arr.Find(40));

            //3
            //Console.WriteLine(arr.Find(arr2));

            //4 
            //int[] arr3 = arr.Plus(arr2);
            //foreach (int i in arr3)
            //    Console.Write(i + " ");

            Predicate<int> predicate = (num) => num % 2 == 0; // Только четные числа
            int[] ints = arr.Get(predicate);
            foreach(var i in ints)
            {
                Console.WriteLine(i + " ");
            }


        }
    }
}