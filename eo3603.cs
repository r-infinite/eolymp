using System;

namespace OlimpSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[] arr = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 };

            while (true)
            {
                int nlog = (int)Math.Round(Math.Log(n, 2));

                n = Math.Abs(arr[nlog] - n);

                count++;

                if (n == 0) break;
            }

            Console.WriteLine(count);
        }
    }
}
