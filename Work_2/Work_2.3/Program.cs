using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int N = int.Parse(Console.ReadLine());
                int M = int.Parse(Console.ReadLine());
                double result = 0;
                double[] a = new double[N];
                if (4 > N || N > 10 || N % 2 != 0)
                    throw new Exception("количество колёс должно быть чётно и от 4 до 10");
                if (N > M || M > 20)
                    throw new Exception("количество шин должно быть в пределах от кол-ва колёс до 20");
                for (int i = 0; i < N; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                    if (0 > a[i] || a[i] > 3000)
                        throw new Exception("значение для шины вышло за пределы от 0 до 3000");
                }
                double a1=a[0], a2=a[1];
                for (int i = 0; i < N; i++)
                {
                    if (i < N / 2)
                        a[i] = a[i] - 1000;
                    else
                        a[i] = a[i] - 500;
                }
                a[0] = a1;a[1] = a2;
                for (int i = 0; i < N; i++)
                {
                    if (i < N / 2)
                        a[i] = a[i];
                    else
                        a[i] = a[i] * 2;
                }
                result = a[M - N];
                Console.WriteLine("Ответ " + Math.Round(result + 1000, 3));
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

        }
    }
}
