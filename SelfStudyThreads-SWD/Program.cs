using System;
using System.Threading;

namespace SelfStudyThreads_SWD
{
	class Programx
	{
		static void Main(string[] args)
		{

			bool yeet = true;
			HelloWriter s1 = new HelloWriter("writer1");

			HelloWriter s2 = new HelloWriter("writer2");

			s1.AmountOfTimeToSleep = 200;
			s2.AmountOfTimeToSleep = 500;

			Thread t1 = new Thread(s1.SayHello);

			Thread t2 = new Thread(s2.SayHello);

			Thread t3 = new Thread(() => 
			{
				while (yeet)
				{
					Console.WriteLine("Never ending story");
					Thread.Sleep(5000);
				}
			});


			t1.Start(20);
			t2.Start(20);
			t3.Start();
			t1.Join();
			t2.Join();
			yeet = false;
			Console.WriteLine("Hello From Main");

		}
	}
}
