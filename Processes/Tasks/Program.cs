using System.Runtime.CompilerServices;

namespace Tasks
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region TASK 1
			//Task task1 = new Task(() => Console.WriteLine($"Task 1: {DateTime.Now}"));
			//task1.Start();

			//Task task2 = Task.Factory.StartNew(() => Console.WriteLine($"Task 2: {DateTime.Now}"));

			//Task task3 = Task.Run(() => 
			//{
			//	Console.WriteLine($"Task 3: {DateTime.Now}");
			//});
			#endregion

			#region TASK 2
			//Task task = new Task(ShowPrimeNumbers);
			//task.Start();
			//task.Wait();
			//         Console.WriteLine("Task is ended.");
			#endregion

			#region TASK 3
			//Task task = new Task(() => Console.WriteLine(ShowCountOfPrimeNumbers(1, 1000)));
			//task.Start();
			//task.Wait();
			#endregion

			#region TASK 4
			//int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

			//Task[] tasks = new Task[4]
			//{
			//	new Task(() => Console.WriteLine($"Min: {nums.Min()}")),
			//	new Task(() => Console.WriteLine($"Max: {nums.Max()}")),
			//	new Task(() => Console.WriteLine($"Avg: {nums.Average()}")),
			//	new Task(() => Console.WriteLine($"Sum: {nums.Sum()}"))
			//};

			//foreach (var t in tasks)
			//	t.Start();

			//Task.WaitAll(tasks);
			#endregion

			#region TASK 5
			//int[] arr = { 7, 2, 3, 4, 3, 5, 6, 5, 1 };
			//Task task1 = new Task(() => DistinctArray(arr));
			//Task task2 = task1.ContinueWith(t => SortArray(arr));

			//task1.Start();
			//task2.Wait();

			//foreach (var i in arr)
			//	Console.WriteLine(i);
			#endregion
		}
		static void DistinctArray(int[] arr) => arr.Distinct();
		static void SortArray(int[] arr) => Array.Sort(arr);
		static void ShowPrimeNumbers()
		{
			for (int i = 2; i <= 1000; i++)
			{
				bool isPrime = true;

				for (int j = 2; j <= Math.Sqrt(i); j++)
				{
					if (i % j == 0)
					{
						isPrime = false;
						break;
					}
				}

				if (isPrime)
					Console.Write(i + " ");
			}
            Console.WriteLine();
        }
		static int ShowCountOfPrimeNumbers(int start, int end)
		{
			int numCounter = 0;
			if (start >= end && start < 0)
				Console.WriteLine("Enter correct limits.");

			for (int i = start; i <= end; i++)
			{
				bool isPrime = true;

				for (int j = 2; j <= Math.Sqrt(i); j++)
				{
					if (i % j == 0)
					{
						isPrime = false;
						break;
					}
				}

				if (isPrime)
					numCounter++;
			}
			return numCounter;
		}
	}
}