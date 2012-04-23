using System;
using NUnit.Framework;

namespace AssignmentTests
{
	[TestFixture()]
	public class ATest
	{
		public static int PROCESS_WAIT_TIME = 1000;
		
		protected AppRunner Runner {get; set;}
		
		[TestFixtureSetUp()]
		public void TestFixtureSetUp ()
		{
			// Get app name under test
			Console.Write ("Executable under test: ");
			string appName = Console.ReadLine ();
			Console.WriteLine ();
			
			this.Runner = new AppRunner(appName);
		}
		
		[TearDown()]
		public void TearDown ()
		{
			Assert.IsTrue (this.Runner.StopApp(PROCESS_WAIT_TIME), "Application did not stop in time");
		}
		
		[Test()]
		public void TestTests ()
		{
			Assert.IsTrue (true, "testing framework isn't feeling well today");
		}
		
		[Test()]
		public void TestProcessLaunches ()
		{
			this.Runner.StartApp (null);
			Assert.IsTrue (this.Runner.IsRunning(), "Application did not launch properly.");
			this.Runner.WriteInputLine ("");
		}
	}
}
