using NLog;

namespace NLogTest
{
	public class Program
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();

		static void Main()
		{
			AppDomain test = AppDomain.CurrentDomain;
			test.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);

			logger.Info("Starting robot arm program");

			int i = 0;
			RobotArm arm = new RobotArm();
			arm.Disconnect();
			i++;
			//}
			throw new Exception("2");

			logger.Info("Robot arm program finished");
		}


		public static void MyHandler(object sender, UnhandledExceptionEventArgs e)
		{
			logger.Fatal("Unhandled Exception {0}",e.ExceptionObject.ToString());
		}
	}
}
