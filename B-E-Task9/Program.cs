using System;

namespace B_E_Task9
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[0];
            arr = arr.Add(1);
            arr = arr.Add(2);
            arr = arr.Add(3);
            arr = arr.Add(4);
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
    public static class Extention
    {
        public static int[] Add(this int[] array,int add)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length-1] = add;
            return array;
        }
    }
}
