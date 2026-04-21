using System;

class Program
{
  static void Main()
  {
    int[] arr = InputArray();

    Console.Write("Введіть К: ");
    int k = int.Parse(Console.Readline());

    Console.Write("Введіть Т: ");
    int t = int.Parse(Console.Readline());

    DeleteElements(ref arr, k, t);

    Console.WriteLine("Результат:");
    PrintArray(arr);
}

static int[] InputArray()
{
  Console.Write("Кількість елементів: ");
  int n = int.Parse(Console.ReadLine());

  int[] arr = new int[n];

  for (int i = 0; i < n; i++)
  {
    Console.Write("arr[" + i + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
  }

  return arr;
}

static void PrintArray(int[] arr)
{
  for (int i = 0; i < arr.Lengh; i++)
  Console.Write(arr[i] + " ");
  Console.WriteLine();
}

static void DeleteElements(ref int[] arr, int k, int t)
{
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
