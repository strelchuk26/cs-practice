namespace UnsafeCode
{
	internal class Program
	{
		unsafe static int* GenerateArr(int size)
		{
			Random rnd = new Random();
			int[] arr = new int[size];

			fixed (int* arrPtr = arr)
			{
				for (int* p = arrPtr; p < arrPtr + size; ++p)
					*p = rnd.Next(100);

				return arrPtr;
			}
		}

		static void Main(string[] args)
		{
			unsafe 
			{
                Console.Write("Enter size of first array: ");
                int N = Int32.Parse(Console.ReadLine());
                Console.Write("Enter size of second array: ");
				int M = Int32.Parse(Console.ReadLine());

				int* arrA = GenerateArr(N);
				int* arrB = GenerateArr(M);

				int* arrC = stackalloc int[N + M];

                Console.WriteLine("\nFirst array:");
                for (int i = 0; i < N; i++)
				{
                    arrC[i] = arrA[i];
                    Console.Write(arrA[i]);
				}

                Console.WriteLine("\nSecond array:");
				for (int i = 0; i < M; i++)
				{
					arrC[i + N] = arrB[i];
                    Console.Write(arrB[i]);
				}

                Console.WriteLine("\nThird array:");
				for (int i = 0; i < M + N; i++)
                    Console.Write(arrC[i]);
            }
		}
	}
}