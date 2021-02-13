using System;
using System.Diagnostics;
using System.Linq;


namespace Work_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch swatch = new Stopwatch();
            //swatch.Start();
            //long before = GC.GetTotalMemory(false);
            short N = short.Parse(Console.ReadLine());//белые
            short M = short.Parse(Console.ReadLine());//чёрные
            byte[] array = new byte[N+M+1];
            int leftmouse = N;
            int rightmouse = M * 2;
            for (int i = 0; i < N+M+1; i++)
            {
                if (i < N)
                    array[i]=1;//белая мышь
                if(i==N)
                    array[i] = 3;//пустота
                if (i > N)
                    array[i] = 2;//чёрная мышь
            }
            int count = 0;
            byte temp;
            while (leftmouse != M * 2 || rightmouse !=N)
            { 
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 1 && array.ElementAtOrDefault(i + 1) == 3)
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        count++;
                    }
                    if (array[i] == 2 && array.ElementAtOrDefault(i - 1) == 3)
                    {                        
                        temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                        count++;
                        break;
                    }
                    if (array[i] == 1 && array.ElementAtOrDefault(i + 1) == 2 && array.ElementAtOrDefault(i + 2) == 3)
                    {
                        temp = array[i];
                        array[i] = array[i + 2];
                        array[i + 2] = temp;
                        count++;
                        break;
                    }
                    if (array[i] == 2 && array.ElementAtOrDefault(i - 1) == 1 && array.ElementAtOrDefault(i-2) == 3)
                    {
                        temp = array[i];
                        array[i] = array[i - 2];
                        array[i - 2] = temp;
                        count++;
                    }
                }
                leftmouse = 0;
                rightmouse = 0;
                for (int j = 0; j < M; j++)
                {
                    leftmouse += array[j];
                }
                for (int j = M + 1; j < array.Length; j++)
                {
                    rightmouse += array[j];
                }
            }
            Console.WriteLine(count);
            //swatch.Stop();
            //Console.WriteLine(swatch.ElapsedMilliseconds);
            //long after = GC.GetTotalMemory(true);
            //long consumedInMegabytes = (after - before);
            //Console.WriteLine(consumedInMegabytes);
        }
    }
}
