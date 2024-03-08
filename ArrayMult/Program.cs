using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture =
            CultureInfo.InvariantCulture;

            float[,] A = new float[2, 2];
            float[] b = new float[2];
      
      
            for (int k = 0; k < 2; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    A[k, j] = float.Parse(args[k * 2 + j]);
                }
                b[k] = float.Parse(args[4 + k]);
            }
            
            float[] result = new float[2];
            for (int k = 0; k < 2; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[k] += A[k, j] * b[j];
                }
            }
            Console.WriteLine($"{result[0]}");
            Console.WriteLine($"{result[1]}");
        }
    }
}
