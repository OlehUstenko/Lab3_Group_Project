namespace ConsoleApp1
{
    public partial class Program
    {
        static int[] array;
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                //тут треба зробити меню виводу. Я в суботу зроблю

            }
        }
        static void ArrayPrint(int[] array)
        {
            if (array.Length > 0)
            {
                for (int i = 0; i<array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            else Console.WriteLine("Масив порожній!");

        }
    }
}
