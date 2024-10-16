using System.Security.Cryptography.X509Certificates;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[] num = [2, 4, 6];
            int target = 6;
            List<int> answer = new List<int>();


            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 1; j < num.Length; j++)
                {
                    int findingTarget = num[i] + num[j];

                    if (findingTarget == target)
                    {
                        answer.Add(i);
                        answer.Add(j);
                    }
                }
            }
            Console.WriteLine($"{answer[0]},{answer[1]}");

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
        }
    }
}
