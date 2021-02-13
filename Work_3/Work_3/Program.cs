using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
            //swatch.Start();
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int max = N;
            int result = 0;
            for (int i = 0; i < N; i++)
                array[i] = i;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        for (int f = 0; f < N; f++)
                        {
                            if ((array[i] + array[j] + array[k] + array[f]) == N && ((array[i]==A || array[i] == B) &&
                                (array[j] == A || array[j] == B) && (array[k] == A || array[k] == B) && (array[f] == A || array[f] == B)))
                            {
                                result = array[i] * array[j] * array[k]* array[f];
                                if (max < result)
                                    max = result;
                            }
                        }
                        if ((array[i]+array[j]+array[k]) == N && ((array[i] == A || array[i] == B) &&
                                (array[j] == A || array[j] == B) && (array[k] == A || array[k] == B)))
                        {
                            result = array[i] * array[j] * array[k];
                            if (max < result)
                                max = result;
                        }
                    }
                    if ((array[i] + array[j]) == N && ((array[i] == A || array[i] == B) &&
                                (array[j] == A || array[j] == B)))
                    {
                        result = array[i] * array[j];
                        if (max < result)
                            max = result;
                    }
                }
            }
            Console.WriteLine(max);
            //swatch.Stop();
            //Console.WriteLine(swatch.ElapsedMilliseconds);
        }
        
    }
}
