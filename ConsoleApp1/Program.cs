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
                Console.WriteLine("ЛАБОРАТОРНА РОБОТА 3 (БЛОК 1)" +
                    "\nПоточний стан масиву: " );
                ArrayPrint(array);

                Console.WriteLine("" +
                    "\nОберіть дію" +
                    "\n1. Заповнити масив вручну" +
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
                        //метод заповнення вручну
                        break;
                    case "2":
                        //метод заповнення рандомом
                        break;
                    case "3":
                        VariantUstenko();
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
    }
}
