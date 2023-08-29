using BenchmarkDotNet.Running;
using CodeBenchmark.src.Boxing;
using CodeBenchmark.src.CollectionReturnType;
using CodeBenchmark.src.Dynamic;
using CodeBenchmark.src.ForLoop;
using CodeBenchmark.src.Serialization;
using CodeBenchmark.src.String;
using CodeBenchmark.src.SyncAsync;

public class Program
{
    private static readonly List<string> BenchmarkTypes = new List<string>()
        {
            "1. Serialization",
            "2. Boxing",
            "3. Dynamic",
            "4. SyncAsync",
            "5. ForLoop",
            "6. CollectionReturnType",
            "7. StringBenchmark"
        };
    static void Main(string[] args)
    {
        Console.WriteLine("Please specify one of the following options to run the corresponding benchmark:");
        Console.WriteLine(string.Join(",\n", BenchmarkTypes.ToArray()));

        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                var serializationSummary = BenchmarkRunner.Run<SerializationBenchmark>();
                break;
            case "2":
                var boxingSummary = BenchmarkRunner.Run<BoxingBenchmark>();
                break;
            case "3":
                var dynamicSummary = BenchmarkRunner.Run<DynamicBenchmark>();
                break;
            case "4":
                var syncAsync = BenchmarkRunner.Run<SyncAsyncBenchmark>();
                break;
            case "5":
                var forLoop = BenchmarkRunner.Run<ForLoopBenchmark>();
                break;
            case "6":
                var returnType = BenchmarkRunner.Run<CollectionReturnTypeBenchmark>();
                break;
            case "7":
                var stringbenchmark = BenchmarkRunner.Run<StringBenchmark>();
                break;
        }

        Console.ReadLine();
    }
}