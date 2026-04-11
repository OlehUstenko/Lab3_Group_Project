using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Program
    {
        static void VariantTimofeiev(ref int[] array)
        {

            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Масив порожній! Немає елементів для обробки.\n");
                return;
            }
            else if (array.Length == 1)
            {
                Console.WriteLine("Масив містить лише один елемент! Немає максимуму та мінімуму для порівняння.\n");
                return;
            }
            else if (array.Length == 2)
            {
                array = null;
                return;
            }

            int maximum = array[0], minimum = array[0];
            int maximumIndx = 0, minimumIndx = 0;
            int[] result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[array.Length - 1 - i] >= maximum)
                {
                    maximumIndx = array.Length - 1 - i;
                    maximum = array[array.Length - 1 - i];
                }
                if (array[i] <= minimum)
                {
                    minimumIndx = i;
                    minimum = array[i];
                }
            }
            if (maximumIndx < minimumIndx)
            {
                ExcludeRange(minimumIndx, maximumIndx, ref result);
            }
            else if (maximumIndx > minimumIndx)
            {
                ExcludeRange(maximumIndx, minimumIndx, ref result);
            }

            array = result;

        }
        static void ExcludeRange(int first, int second, ref int[] result)
        {
            result = new int[array.Length - (first - second + 1)];
            array[..second].CopyTo(result, 0);
            array[(first + 1)..].CopyTo(result, second);
        }
    }
}
