namespace Module_4_Massive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunTask_1();
            RunTask_2();
        }
        static void RunTask_1()
        {
            Console.WriteLine("Enter number of lines");
            int lines = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns");
            int columns = int.Parse(Console.ReadLine());

            int[,] randMatrix = new int[lines, columns];

            Random ran = new Random();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    randMatrix[i, j] = ran.Next(10);

                    Console.Write($"{randMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void RunTask_2()
        {
            Console.WriteLine("Enter number of lines");
            int lines = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns");
            int columns = int.Parse(Console.ReadLine());

            Random ran = new Random();

            int[,] Matrix_A = new int[lines, columns];
            int[,] Matrix_B = new int[lines, columns];
            int[,] Matrix_C = new int[lines, columns];

            int[][,] AllMatrix = new int[3][,];

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Matrix_A[i, j] = ran.Next(10);

                    Matrix_B[i, j] = ran.Next(10);

                    Matrix_C[i, j] = Matrix_A[i, j] + Matrix_B[i, j];               
                }
            }
            AllMatrix[0] = Matrix_A;
            AllMatrix[1] = Matrix_B;
            AllMatrix[2] = Matrix_C;

            int count = 1;

            foreach (int[,] massive in AllMatrix)
            {                  
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{massive[i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("_______________________");
                Console.WriteLine($"Matrix # {count++}");
                Console.WriteLine("_______________________");
            }
        }
    }
}
