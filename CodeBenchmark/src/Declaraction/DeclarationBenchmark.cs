using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBenchmark.src.Declaraction
{
    [MemoryDiagnoser]
    public class DeclarationBenchmark
    {
        [Params(100)]
        public int N;

        [Benchmark]
        public void TestArrayClassDeclaration()
        {
            ClassObject[] classObjects = new ClassObject[N];
            for (int i = 0; i < N; i++)
            {
                ClassObject sb = new ClassObject();
                sb.id = i.ToString();
                sb.index = i;
                classObjects[i] = sb;
            }
        }

        [Benchmark]
        public void TestArrayStructDeclaration()
        {
            StructObject[] classObjects = new StructObject[N];
            for (int i = 0; i < N; i++)
            {
                StructObject sb = new StructObject();
                sb.id = i.ToString();
                sb.index = i;
                classObjects[i] = sb;
            }
        }

        [Benchmark]
        public void TestClassDeclaration()
        {
            for (int i = 0; i < N; i++)
            {
                ClassObject sb = new ClassObject();
                sb.id = i.ToString();
                sb.index = i;
            }
        }

        [Benchmark]
        public void TestStructDeclaration()
        {
            for (int i = 0; i < N; i++)
            {
                StructObject sb = new StructObject();
                sb.id = i.ToString();
                sb.index = i;
            }
        }
    }
}
