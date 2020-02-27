using System;

namespace Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input N = ");
            int N = int.Parse(Console.ReadLine());
            int M = 10 * N;
            char[,] Logo = new Char[N + 1, M];

            for (int i = 0; i <= N; i++)            // Init
                for (int j = 0; j < M; j++)
                    Logo[i, j] = '-';

            // First Letter M

            for (int i = 0; i <= N; i++)            // First Up Movement
                for (int j = N - i; j < 2 * N - i; j++)
                    Logo[i, j] = '*';

            for (int i = N; i >= 0; i--)            // First Down Movement
                for (int j = N + i; j < 2 * N + i; j++)
                    Logo[i, j] = '*';

            for (int i = 0; i <= N; i++)            // Second Up Movement
                for (int j = 3 * N - i; j < 4 * N - i; j++)
                    Logo[i, j] = '*';

            for (int i = N; i >= 0; i--)            // Second Down Movement
                for (int j = 3 * N + i; j < 4 * N + i; j++)
                    Logo[i, j] = '*';

            // Second Letter M

            for (int i = 0; i <= N; i++)            // First Up Movement
                for (int j = 6 * N - i; j < 7 * N - i; j++)
                    Logo[i, j] = '*';

            for (int i = N; i >= 0; i--)            // First Down Movement
                for (int j = 6 * N + i; j < 7 * N + i; j++)
                    Logo[i, j] = '*';

            for (int i = 0; i <= N; i++)            // Second Up Movement
                for (int j = 8 * N - i; j < 9 * N - i; j++)
                    Logo[i, j] = '*';

            for (int i = N; i >= 0; i--)            // Second Down Movement
                for (int j = 8 * N + i; j < 9 * N + i; j++)
                    Logo[i, j] = '*';

            for (int i = 0; i <= N; i++)            // Result
            {
                for (int j = 0; j < M; j++)
                    Console.Write(Logo[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("The end!");
        }
    }
}
