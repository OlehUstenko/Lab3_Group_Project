using System.Drawing;
using System.Text;

namespace ConsoleApp1
{
    public partial class Program
    {
        static int[] array;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nЛАБОРАТОРНА РОБОТА 3 (БЛОК 1)" +
                    "\n\nПоточний стан масиву: " );
                ArrayPrint(array);

                Console.WriteLine("" +
                    "\nОберіть дію" +
                    "\n1. Заповнити масив вручну через пробіл" +
                    "\n2. Заповнити масив рандом" +
                    "\n3. Виконати варіант Олега (Варіант 5)" +
                    "\n4. Виконати варіант Євгена (Варіант 9)" +
                    "\n5. Виконати варіант Серафима (Варіант 2)" +
                    "\n0. Вихід" +
                    "\nОберіть дію: ");
                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        array = HandSpace();
                        break;
                    case "2":
                        array = RandomArray();
                        break;
                    case "3":
                        VariantUstenko(ref array);
                        break;
                    case "4":
                        VariantTimofeiev(ref array);
                        break;
                    case "5":
                        //метод Варіанту
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Помилка! Не знайдено такого варіанту!\n");
                        break;
                }
            }
        }
        static void ArrayPrint(int[] array)
        {
            if (array == null)
            {
                Console.Write("Масив порожній!\n");
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString() + " ");
            }
            Console.WriteLine();
        }
        static int[] HandSpace()
        {
            Console.WriteLine("Введіть значення масиву через пробіл:");
            string[] input = Console.ReadLine().Trim().Split();
            int size = input.Length;

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            Console.WriteLine("\n");
            return array;
        }
        static int[] RandomArray()
        {
            Console.Write("Введіть розмір масиву: ");
            int size = int.Parse(Console.ReadLine());

            Console.Write("Введіть мінімальне значення рандому: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Введіть максимальне значення рандому: ");
            int max = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max);
            }
            Console.WriteLine("\n");
            return array;
        }
    }
}
