using System;
using System.Globalization;

namespace exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] A;
            double maior = 0.0;
            int posicao = 0;

            N = int.Parse(Console.ReadLine());
            A = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);

                if (A[i] > maior)
                {
                    posicao = i;
                    maior = A[i];
                }

            }

            Console.WriteLine(maior.ToString("F1"), CultureInfo.InvariantCulture);
            Console.WriteLine(posicao);
            Console.WriteLine("o nando tem um bundao bonitao");



            Console.ReadLine();

        }
    }
}
