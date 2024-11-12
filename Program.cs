namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] A = [1, 7, 9];
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
                if (A[posA] > B[posB])
                {
                    if (i == 0)
                        A[i] = B[posB];

                    B[i] = A[posA];
                    if(posA > 0)
                        posA--;
                }
                else
                {
                    if (i == 0)
                        B[i] = A[posA];

                    B[i] = B[posB];
                    
                    if (posB > 0)
                        posB--;
                }                     
                
            }

            Console.WriteLine(string.Join(", ", B));
        }
    }
}
