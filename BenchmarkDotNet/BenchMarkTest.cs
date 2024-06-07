using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetTest
{
    public class BenchMarkTest
    {
        [Benchmark]
        public int[] BubbleSort()
        {
            int[] listaNumeros = { 64, 34, 25, 12, 22, 11, 90 };

            int n = listaNumeros.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (listaNumeros[j] > listaNumeros[j + 1])
                    {
                        int temp = listaNumeros[j];
                        listaNumeros[j] = listaNumeros[j + 1];
                        listaNumeros[j + 1] = temp;
                    }
                }
            }
            return listaNumeros;
        }

        [Benchmark]
        public int[] InsertionSort()
        {
            int[] listaNumeros = { 64, 34, 25, 12, 22, 11, 90 };

            int n = listaNumeros.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = listaNumeros[i];
                int j = i - 1;

                while (j >= 0 && listaNumeros[j] > key)
                {
                    listaNumeros[j + 1] = listaNumeros[j];
                    j = j - 1;
                }
                listaNumeros[j + 1] = key;
            }

            return listaNumeros;
        }
    }
}
