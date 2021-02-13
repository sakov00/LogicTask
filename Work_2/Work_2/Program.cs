using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2
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

                if (N >M || M > 20)
                    throw new Exception("количество шин должно быть в пределах от кол-ва колёс до 20");
                for (int i = 0; i < N; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                    if (0 > a[i] || a[i] > 3000)
                        throw new Exception("значение для шины вышло за пределы от 0 до 3000");
                }
                double temp;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] > a[j])
                        {
                            temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < N; i++)
                {
                    if (i < N / 2 && N % 2 != 1)
                        a[i] = a[i] * 1.5;
                    else
                        a[i] = a[i] * 0.5;
                }
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] > a[j])
                        {
                            temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
                result = a[M - N];
                Console.WriteLine("Ответ " + Math.Round(result, 3));
                /*колёса сзади изнашиваются в 1.5 быстрее, а спереди в 1.5 раза медленнее,
                отсортировал колёса для того чтобы определить какое будет спереди а какое сзади
                , затем те что сзади умножаю на 1.5 а те что спереди на 0.5 и после опять сортирую
                для того чтобы найти самое слабое колесо и если есть запасные шины то просто получу
                то колесо на которого запаску не хватит и из-за него мы не сможем поехать дальше,
                а ответ это уже сколько проехало это колесо*/
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

        }
    }
}
