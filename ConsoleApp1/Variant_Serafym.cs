using System;

namespace ConsoleApp1
{
    public partial class Program
    {
        static void VariantSerafym(ref int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Масив порожній! Спочатку заповніть його.");
                return;
            }

            int indexToRemove = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] < 0)
                {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove == -1)
            {
                Console.WriteLine("Від'ємних чисел не знайдено. Масив не змінено.");
                return;
            }

            for (int i = indexToRemove; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            Array.Resize(ref arr, arr.Length - 1);
            Console.WriteLine("Останній від'ємний елемент успішно видалено.");
        }
    }
}
