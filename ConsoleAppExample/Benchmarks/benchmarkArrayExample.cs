using BenchmarkDotNet.Attributes;

namespace ConsoleAppExample.Benchmarks;
[MemoryDiagnoser(false)]
public class benchmarkArrayExample
{

    [Benchmark]
    public void Multidimensional_Array()
    {

        long[,] _data = new long[ExampleData.Length, ExampleData.Length];

        var data = ExampleData.ExampleDatas();

        for (int i = 0; i < ExampleData.Length; ++i)
        {
            for (int j = 0; j < ExampleData.Length; ++j)
            {
                _data[i, j] = data[i];
            }
        }
    }

    [Benchmark]
    public void jagged_Array()
    {


        long[][] _data = new long[ExampleData.Length][];
        var data = ExampleData.ExampleDatas();

        for (int i = 0; i < ExampleData.Length; ++i)
        {
            for (int j = 0; j < ExampleData.Length; ++j)
            {
                _data[i] = new long[ExampleData.Length];
                _data[i][j] = data[i];
            }
        }
    }
}
