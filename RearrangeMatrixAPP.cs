namespace RearrangeMatrixAPP
{
    internal class Program
    {
        static int[,] Matrix(int rows,int cols)
        {
            int[,] M = new int[rows, cols];

            int[] A = new int[rows * cols];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = i;
            }

            Random rng = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                int j = rng.Next(i, A.Length);
                int tmp = A[i];
                A[i] = A[j];
                A[j] = tmp;
            }

            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    M[i, j] = A[index++];
                }
            }
            return M;
        }

        static void Display(int[,] M)
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write("{0,5}", M[i, j]);
                }
                Console.WriteLine();
            }
        }


            static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns:");
            int cols = int.Parse(Console.ReadLine());

            int[,]M = Matrix(rows, cols);
     
            /*
            int[,]M= new int[rows, cols];

            int[]A =new int [rows*cols];
            for (int i=0;i<A.Length;i++)
            {
                A[i] = i;
            }

            Random rng = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                int j = rng.Next(i,A.Length);
                int tmp = A[i];
                A[i] =A[j];
                A[j] = tmp;
            }

            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    M[i, j] = A[index++];
                }
            }
            */

            Console.WriteLine("Matrix after filling with random values:");

            /*
            for (int i = 0;i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write("{0,5}", M[i, j]);
                }
                Console.WriteLine();
            }
            */

            Display(M);

            for(int i = 0;i<rows;i++)
            {
                for(int j = i+1;j<rows;j++)
                {
                    if (M[i, 0] > M[j,0])
                    {
                        for (int k = 0; k < cols; k++)
                        {
                            int tmp = M[i, k];
                            M[i, k] = M[j, k];
                            M[j, k] = tmp;
                        }
                    }
                }
            }

            Console.WriteLine("Matrix after performing row exchanges based on the first column:");

            Display(M);

            /*
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write("{0,5}", M[i, j]);
                }
                Console.WriteLine();
            }
            */


        }
    }
}
