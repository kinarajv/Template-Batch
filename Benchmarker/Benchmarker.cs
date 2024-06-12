using BenchmarkDotNet.Attributes;
using System.Text;

namespace StringVsStringBuilderBenchmark
{
	[MemoryDiagnoser] 
	public class ConcatenationBenchmark
	{
		[Params(10, 1000, 10000)]
		public int NumIterations;
		private const string TextToAppend = "Hello, world!";

		[Benchmark]
		public string StringConcatenation()
		{
			string result = string.Empty;
			for (int i = 0; i < NumIterations; i++)
			{
				result += TextToAppend;
			}
			return result;
		}

		[Benchmark]
		public string StringBuilderConcatenation()
		{
			var builder = new StringBuilder();
			for (int i = 0; i < NumIterations; i++)
			{
				builder.Append(TextToAppend);
			}
			return builder.ToString();
		}
	}
}
