using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace foreach_vs_parallel
{

    [MemoryDiagnoser]
    [MinColumn, MaxColumn]
    public  class ListIterationPerformance
    {
        [Params(10, 20)]
        public int count;

        private IEnumerable<int> _list;

        [GlobalSetup]
        public void Setup()
        {
            _list = Enumerable.Range(0, count);
        }

        [Benchmark]
        public void ForeachPerformance() 
        {
            foreach (var list in _list)
                DoSomeStuff();
        
        }
        [Benchmark]
        public void ParallelPerformance()
        {
            Parallel.ForEach(_list, item => DoSomeStuff());


        }
        private void DoSomeStuff()
        {
            for (int i = 0; i < 100; i++) ;
        }
    }
}
