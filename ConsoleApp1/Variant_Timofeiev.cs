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
                result = new int[array.Length - (minimumIndx - maximumIndx + 1)];
                array[..maximumIndx].CopyTo(result, 0);
                array[(minimumIndx + 1)..].CopyTo(result, maximumIndx);
            }
            else if (maximumIndx > minimumIndx)
            {
                result = new int[array.Length - (maximumIndx - minimumIndx + 1)];
                array[..minimumIndx].CopyTo(result, 0);
                array[(maximumIndx + 1)..].CopyTo(result, minimumIndx);
            }

            array = result;

        }

    }
}
