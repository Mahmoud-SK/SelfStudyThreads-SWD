using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SelfStudyThreads_SWD
{
	public class HelloWriter
	{
		string _name;
		//int _numberOfTimesToLoop; Den ene måde

		//public int _numberOfTimesToLeep { get; set; }

		public int AmountOfTimeToSleep { get; set; }
		public HelloWriter(string name)
		{
			_name = name;
		}

		public void SayHello(object numberoftimestoloop)
		{
			for (int i = 0; i < (int)numberoftimestoloop; i++)
			{
				Console.WriteLine($"Hello from {_name} #{i}");
				Thread.Sleep(AmountOfTimeToSleep);
			}
		}
	}
}
