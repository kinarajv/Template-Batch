using NLog;
using NLog.Config;

class Program
{
	static void Main(string[] args)
	{
        // Load the NLog configuration from a different file
        string currentDirectory = Directory.GetCurrentDirectory();
        string nlogConfigPath = Path.Combine(currentDirectory, "nlog.config");
        LogFactory logFactory = LogManager.LoadConfiguration(nlogConfigPath);
		Logger logger = logFactory.GetLogger("Program");
		logger.Info("Hello, world!");

		// Use NLog as usual
		Logger logger2 = LogManager.GetCurrentClassLogger();
		logger2.Info("Hello, world!");
	}
}
