using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[30];
        Random rnd = new Random();

        // Заповнення масиву випадковими числами
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(100);
        }

        // Вивiд вихiдного масиву
        Console.WriteLine("Вихiдний масив:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        // Сортування методом бульбашки
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        // Вивiд вiдсортованого масиву
        Console.WriteLine("\n Масив, вiдсортований методом бульбашки:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        // Сортування методом вибору
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

        // Вивiд вiдсортованого масиву
        Console.WriteLine("\nМасив, вiдсортований методом вибору:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        Console.ReadKey();
    }
}

