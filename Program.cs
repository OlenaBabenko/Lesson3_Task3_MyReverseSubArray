using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyReverseSubArray
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int countElement;

            Console.Write($"Input count element of array: ");
            while (!int.TryParse(Console.ReadLine(), out countElement) || countElement <= 0)
            {
                Console.WriteLine("Invalid value! Try again: ");
            }

            int[] array = new int[countElement];
            InputArray(array);
            MyReverse(array);
            SubArray(ref array, 3, 10);

            for (int i = 3; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }
        static void InputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Input {i + 1} element of array: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Invalid value! Try again: ");
                }
            }
        }
        static void MyReverse(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }

        static int[] SubArray(ref int[] array, int index, int count)
        {
            int[] newArray = new int[count];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= index && array[i] <= array.Length)
                {
                    newArray[i] = array[i];
                }
            }

            for (int i = array.Length; i < count; i++)
            {
                newArray[i] = 1;
            }
            array = newArray;
            return array;
        }
    }
}


