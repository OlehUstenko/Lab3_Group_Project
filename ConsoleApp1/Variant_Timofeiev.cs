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

        }

    }
}
