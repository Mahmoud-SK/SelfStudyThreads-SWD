using System;
using System.Collections.Generic;
using System.Text;

namespace SelfStudyThreadsCount
{
    class Counter
    {
        TotalCount _totalCount;
        public Counter(TotalCount totalCount)
        {
            _totalCount = totalCount;
        }
        public void StartCounting(object numberOfLoops)
        {
            for (int i = 0; i < (int)numberOfLoops; i++)
            {
                _totalCount.count++;
            }
        }
    }
}
