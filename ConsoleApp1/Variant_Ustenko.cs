using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Program
    {
        public static void VariantUstenko(ref int[] arr)
        {

            // комент для коміта на нову гілку Oleh
            Console.WriteLine("Введіть скільки елементів треба знищити: ");
            int T = int.Parse(Console.ReadLine());
            Console.WriteLine("З якого елементу починати : ");
            int K = int.Parse(Console.ReadLine()) - 1;
            if (K < 0)
            {
                Console.WriteLine("Помилка: Індекс K не може бути від'ємним. Операцію скасовано.");
                return;
            }
            if (K >= arr.Length)
            {
                Console.WriteLine($"Помилка: Індекс {K + 1} поза межами масиву (довжина {arr.Length}).");
                return;
            }
            int count = T;
            if (K + T > arr.Length)
            {
                count = arr.Length - K;
                Console.WriteLine($"Попередження: Буде видалено {count} елементів (все, що було доступно).");
            }

            if (count <= 0)
            {
                Console.WriteLine("Кількість елементів для видалення має бути більшою за 0.");
                return;
            }
            for (int i = K; i < arr.Length - count; i++)
            {
                arr[i] = arr[i + count];
            }
            Array.Resize(ref arr, arr.Length - count);

            Console.WriteLine("Елементи успішно видалено.");
        }

    }
}
