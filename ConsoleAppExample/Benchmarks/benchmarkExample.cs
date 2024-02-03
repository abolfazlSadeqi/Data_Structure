using BenchmarkDotNet.Attributes;
using ConsoleAppExample.Example.Normal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Benchmarks;
[MemoryDiagnoser(false)]
public class benchmarkExample
{
 
    [Benchmark]
    public void Array()
    {
        var data = ExampleData.ExampleDatas();
        int[] _data = new int[ExampleData.Length];

        for (int i = 0; i < ExampleData.Length; ++i)
        {
            _data[i] = data[i];
        }

    }

    [Benchmark]
    public void List()
    {
          var data = ExampleData.ExampleDatas();
        List<int> _data = new List<int>();

        for (int i = 0; i < ExampleData.Length; ++i)
        {
            _data.Add(data[i]);
        }

    }


    [Benchmark]
    public void Dictionary()
    {
          var data = ExampleData.ExampleDatas();
        Dictionary<int, int> _data = new Dictionary<int, int>();

        for (int i = 0; i < ExampleData.Length; ++i)
        {
            _data.Add(i, data[i]);
        }

    }


    [Benchmark]
    public void Hashtable()
    {
          var data = ExampleData.ExampleDatas();
        Hashtable _data = new Hashtable();
        for (int i = 0; i < ExampleData.Length; ++i)
        {
            _data.Add(i, data[i]);
        }

    }

    [Benchmark]
    public void Queue()
    {
          var data = ExampleData.ExampleDatas();
        Queue<int> _data = new Queue<int>();
        for (int i = 0; i < ExampleData.Length; ++i)
        {
            _data.Enqueue(data[i]);
        }

    }

    [Benchmark]
    public void Stack()
    {
          var data = ExampleData.ExampleDatas();
        Stack<int> _data = new Stack<int>();
        for (int i = 0; i < ExampleData.Length; ++i)
        {
            _data.Push(data[i]);
        }
    }


    [Benchmark]
    public void SortedDictionary()
    {
          var data = ExampleData.ExampleDatas();
        SortedDictionary<int, int> _data = new SortedDictionary<int, int>();

        for (int i = 0; i < ExampleData.Length; ++i)
        {
            _data.Add(i, data[i]);
        }
    }

    [Benchmark]
    public void SortedList()
    {
          var data = ExampleData.ExampleDatas();
        SortedList<int, int> _data = new SortedList<int, int>();

        for (int i = 0; i < ExampleData.Length; ++i)
        {
            _data.Add(i, data[i]);
        }
    }

    [Benchmark]
    public void SortedSet()
    {
          var data = ExampleData.ExampleDatas();
        SortedSet<int> _data = new SortedSet<int>();

        for (int i = 0; i < ExampleData.Length; ++i)
        {
            _data.Add( data[i]);
        }
    }

    [Benchmark]
    public void LinkedList()
    {
          var data = ExampleData.ExampleDatas();
        LinkedList<int> _data = new LinkedList<int>();

        for (int i = 0; i < ExampleData.Length; ++i)
        {
            _data.AddLast(data[i]);
        }
    }

   
}
