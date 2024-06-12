using System;
using System.IO;

public class Logger
{
	private string logFilePath = "./log.txt";

	public void Info(string message)
	{
		using (StreamWriter writer = new StreamWriter(logFilePath, true))
		{
			writer.WriteLine($"{DateTime.Now} - Info- {message}");
		}
	}
	public void Warning(string message)
	{
		using (StreamWriter writer = new StreamWriter(logFilePath, true))
		{
			writer.WriteLine($"{DateTime.Now} - Warning - {message}");
		}
	}
}

public static class myProgram
{
	static void Main() 
	{
		Logger logger = new Logger();
		logger.Info("Starting the program...");
		logger.Warning("Program variable not suitable");
		logger.Info("Program completed.");
	}
}