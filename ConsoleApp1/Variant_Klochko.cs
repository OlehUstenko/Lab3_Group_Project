namespace ConsoleApp1
{
    public partial class Program
    {
        public static void Variant4(ref int[] arr)
        {
            if (arr == null)
            {
                Console.WriteLine("Масив порожній!");
                return;
            }
            Console.Write("Введіть К: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введіть Т: ");
            int t = int.Parse(Console.ReadLine());
            if (k < 0 || t < 0 || k + t > arr.Length)
            {
                Console.WriteLine("Дія неможлива: не всі елементи існують у масиві.");
                return;
            }
            if (t == 0)
            {
                Console.WriteLine("T = 0, масив незмінний.");
                return;
            }
            int[] newArr = new int[arr.Length - t];

            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < k || i >= k + t)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            arr = newArr;
        }
    }
}
