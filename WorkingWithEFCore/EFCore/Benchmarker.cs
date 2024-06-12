using System.Security.Cryptography.X509Certificates;
using BenchmarkDotNet.Attributes;
using EFDatabase;
using Microsoft.EntityFrameworkCore;

namespace EFCore;
[MemoryDiagnoser]
public class MyDatabaseBenchmark
{
	private readonly MyDatabase _my;
	public MyDatabaseBenchmark() 
	{
		_my = new();
	}
	[Benchmark]
	public void IncludeFirst() 
	{
		_my.IncludeFirst();
	}
	[Benchmark]
	public void WhereFirst() 
	{
		_my.WhereFirst();
	}
}

