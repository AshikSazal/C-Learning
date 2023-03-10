using System.Diagnostics;
using System.Threading;

namespace MultipleInheritance
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int threads = 4;
            int chunkSize = arr.Length / threads + arr.Length % threads;
            Debug.WriteLine(chunkSize);

            int sum = 0;
            Thread[] threadArray = new Thread[threads];

            for (int i = 0; i < threads; i++)
            {
                int start = i * chunkSize;
                int end = Math.Min((i + 1) * chunkSize, arr.Length);

                threadArray[i] = new Thread(() =>
                {
                    int localSum = 0;
                    for (int j = start; j < end; j++)
                    {
                        localSum += arr[j];
                    }
                    Interlocked.Add(ref sum, localSum);
                });
                threadArray[i].Start();
            }

            foreach (Thread t in threadArray)
            {
                t.Join();
            }

            Debug.WriteLine("Sum: " + sum);
        }

    }
}
