using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Benchmarks;
[MemoryDiagnoser(false)]
public class benchmarkFirsttemExample
{
    [Benchmark]
    public void Array()
    {
        var data = ExampleData.Array();
        var dd = data[0];
        
    }

    [Benchmark]
    public void List()
    {
        var data = ExampleData.List();
        var dd = data.First();
      
    }


    [Benchmark]
    public void Dictionary()
    {
        var data = ExampleData.Dictionary();
        var dd = data.First();
       
    }


    [Benchmark]
    public void Hashtable()
    {
        var data = ExampleData.Hashtable();
        var dd = data[0];
        
    }

    [Benchmark]
    public void Queue()
    {
        var data = ExampleData.Queue();
        var dd = data.Dequeue();
       
    }

    [Benchmark]
    public void Stack()
    {
        var data = ExampleData.Stack();
        var dd = data.Pop();
     
    }


    [Benchmark]
    public void SortedDictionary()
    {
        var data = ExampleData.SortedDictionary();
        var dd = data.First();
     
    }

    [Benchmark]
    public void SortedList()
    {
        var data = ExampleData.SortedList();
        var dd = data.First();
      
    }

    [Benchmark]
    public void SortedSet()
    {
        var data = ExampleData.SortedSet();
        var dd = data.First();
      
    }

    [Benchmark]
    public void LinkedList()
    {
        var data = ExampleData.LinkedList();
        var dd = data.First();
      
    }

    [Benchmark]
    public void HashSet()
    {
        var data = ExampleData.HashSet();
        var dd = data.First();
     
    }
}
