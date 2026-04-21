namespace ConsoleApp1
{
  public partial class Program
  {
    public static void Variant6(ref int[] arr)
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

      if (k < 0)
      {
        Console.WriteLine("K < 0, нічого не робимо");
        return;
      }

      if (k >= arr.Length)
      {
        Console.WriteLine("Початок за межами масиву");
        return;
      }

      int realT = t;
      if (k + t > arr.Length)
        realT = arr.Length - k;

      int[] newArr = new int[arr.Length - realT];
      
      int j = 0;

      for (int i = 0; i < arr.Length; i++)
      {
        if (i < k || i >= k + realT)
        {
          newArr[j] = arr[i];
          j++;
        }
      }
      arr = newArr;
      }
  }
}
      
        
