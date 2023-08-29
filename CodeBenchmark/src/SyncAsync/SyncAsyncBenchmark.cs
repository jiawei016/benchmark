using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBenchmark.src.SyncAsync
{
    internal class SyncExample
    {
        readonly int _number;
        public SyncExample(int number)
        {
            _number = number;
        }

        public int SyncNumber()
        {
            return _number;
        }
    }

    internal class SyncAsyncExample
    {
        readonly int _number;
        public SyncAsyncExample(int number)
        {
            _number = number;
        }

        public async Task<int> SyncAsyncNumber()
        {
            return _number;
        }
    }

    internal class ValueTaskExample
    {
        readonly int _number;
        public ValueTaskExample(int number)
        {
            _number = number;
        }

        public async ValueTask<int> ValueTaskNumber()
        {
            return _number;
        }
    }

    [MemoryDiagnoser]
    public class SyncAsyncBenchmark
    {

        [Params(1000, 5000)]
        public int N;


        [Benchmark]
        public void TestingSyncMethod()
        {
            var sum = 0;

            for (int i = 0; i < N; i++)
            {
                var sync = new SyncExample(i);
                sum += sync.SyncNumber();
            }
        }

        [Benchmark]
        public async Task TestingSyncAsyncMethod()
        {
            var sum = 0;
            for (int i = 0; i < N; i++)
            {
                var sync = new SyncAsyncExample(i);
                sum += await sync.SyncAsyncNumber();
            }
        }

        [Benchmark]
        public void TestingTaskMethod()
        {
            var sum = 0;
            for (int i = 0; i < N; i++)
            {
                var sync = new SyncAsyncExample(i);
                sum += sync.SyncAsyncNumber().Result;
            }
        }

        //[Benchmark]
        //public async Task TestingValueTaskMethod()
        //{
        //    var sum = 0;
        //    for (int i = 0; i < N; i++)
        //    {
        //        var valueTask = new ValueTaskExample(i);
        //        sum += await valueTask.ValueTaskNumber();
        //    }
        //}

    }
}
