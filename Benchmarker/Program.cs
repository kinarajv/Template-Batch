using BenchmarkDotNet.Running;
using StringVsStringBuilderBenchmark;

public class Program 
{
	static void Main() 
	{
		BenchmarkRunner.Run<ConcatenationBenchmark>();
	}
}