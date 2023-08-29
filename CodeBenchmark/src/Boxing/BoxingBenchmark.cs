using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBenchmark.src.Boxing
{
    [MemoryDiagnoser]
    public class BoxingBenchmark
    {

        [Params(1000)]
        public int N;

        [Benchmark]
        public void TestingArrayList()
        {
            var arrayList = new ArrayList();

            for (int i = 0; i < N; i++)
            {
                if (!arrayList.Contains(i))
                {
                    arrayList.Add(i);
                }
            }
        }

        [Benchmark]
        public void TestingObjectList()
        {
            var list = new List<object>();

            for (int i = 0; i < N; i++)
            {
                if (!list.Contains(i))
                {
                    list.Add(i);
                }
            }
        }

        [Benchmark]
        public void TestingIntList()
        {
            var list = new List<int>();

            for (int i = 0; i < N; i++)
            {
                if (!list.Contains(i))
                {
                    list.Add(i);
                }
            }
        }

        [Benchmark]
        public void TestingNumberList()
        {
            var list = new List<Number>();

            for (int i = 0; i < N; i++)
            {
                if (!list.Exists(options => options.num == i))
                {
                    list.Add(new Number(i));
                }
            }
        }
    }
}
