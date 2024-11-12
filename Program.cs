namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] A = [1,7,9];
            int[] B = [2, 4, 8, 0, 0, 0];

            MergeArray(A, B);
            Console.ReadLine();
        }

        public static void MergeArray(int[] A, int[] B)
        {
            int posA = A.Length - 1;
            int posB = B.Length - A.Length - 1;

            for (int i = B.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    if (A[posA] > B[posB])
                    {
                        B[i] = A[posA];
                        posA--;

                    }
                    else
                    {
                        B[i] = B[posB];
                        posB--;
                    }

                }
                
            }

            Console.WriteLine(string.Join(", ", B));
        }
    }
}
