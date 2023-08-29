using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeBenchmark.src.String
{
    [MemoryDiagnoser]
    public class StringBenchmark
    {
        [Params(100)]
        public int N;

        [Benchmark]
        public void TestStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                sb.Append(i.ToString());
            }
        }

        [Benchmark]
        public void TestStringConcat()
        {
            string s = "";
            for (int i = 0; i < N; i++)
            {
                s.Concat(i.ToString());
            }
        }

        [Benchmark]
        public void TestStringPlusOperator()
        {
            string s = "";
            for (int i = 0; i < N; i++)
            {
                s += i.ToString();
            }
        }

        [Benchmark]
        public void TestStringInterpolation()
        {
            string s = "";
            for (int i = 0; i < N; i++)
            {
                s = $"This is string {i.ToString()}";
            }
        }

        [Benchmark]
        public void TestStringStringFormat()
        {
            string s = "";
            for (int i = 0; i < N; i++)
            {
                s = string.Format("This is string {0}", i.ToString());
            }
        }

        [Benchmark]
        public void TestStringReplace()
        {
            string input = "This is   text with   far  too   much   " +
                     "white space.";
            string replacement = " ";
            for (int i = 0; i < N; i++)
            {
                input = input.Replace(" ", replacement);
            }
        }

        [Benchmark]
        public void TestStringRegex()
        {
            string input = "This is   text with   far  too   much   " +
                     "white space.";
            string pattern = "\\s+";
            string replacement = " ";
            for (int i = 0; i < N; i++)
            {
                input = Regex.Replace(input, pattern, replacement);
            }
        }
    }
}
