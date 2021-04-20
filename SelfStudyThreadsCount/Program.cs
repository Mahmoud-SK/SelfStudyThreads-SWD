using System;
using System.Threading;

namespace SelfStudyThreadsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            TotalCount totalCount = new TotalCount();
            Counter counter1 = new Counter(totalCount);
            Counter counter2 = new Counter(totalCount);

            Thread t1 = new Thread(counter1.StartCounting);
            Thread t2 = new Thread(counter2.StartCounting);

            t1.Start(200000);
            t2.Start(500000);

            t1.Join();
            t2.Join();

            Console.WriteLine(totalCount.count);
        }
    }
}
