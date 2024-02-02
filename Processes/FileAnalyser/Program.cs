using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FileAnalyser
{
	class Stat
	{
        public int Words { get; set; }
        public int Lines { get; set; }
        public int Punctuation { get; set; }
    }
	internal class Program
	{
		static void Main(string[] args)
		{
			string path = Console.ReadLine();

			Stat statistic = new Stat();
			var files = Directory.GetFiles(path);

			foreach (var file in files)
			{
				string text = File.ReadAllText(file);
				Thread thread = new Thread(TextAnalyse);
				thread.Start(new object[] { text, statistic });
			}

            Console.WriteLine($"Words: {statistic.Words}\nLines: {statistic.Lines}\nPunctuation: {statistic.Punctuation}");
        }

		static void TextAnalyse(object stat)
		{
			string text = ((object[])stat)[0].ToString();
			var statistic = ((object[])stat)[0] as Stat;

			foreach (var word in text.Split(' '))
			{
				foreach (var symb in word)
				{
					if (char.IsWhiteSpace(symb))
						Interlocked.Increment(ref statistic.Words);

					else if (char.IsWhiteSpace(symb))
						Interlocked.Increment(ref statistic.Lines);

					else if (char.IsPunctuation(symb))
						Interlocked.Increment(ref statistic.Punctuation);
				}
			}
		}
	}
}