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
public class benchmarkFetchItemExample
{
    [Benchmark]
    public void Array()
    {
        var data = ExampleData.Array();
        foreach(var item in data)
        {
           
        }

    }

    [Benchmark]
    public void List()
    {
        var data = ExampleData.List();
        foreach (var item in data)
        {

        }

    }


    [Benchmark]
    public void Dictionary()
    {
        var data = ExampleData.Dictionary();
        foreach (var item in data)
        {

        }

    }


    [Benchmark]
    public void Hashtable()
    {
        var data = ExampleData.Hashtable();
        foreach (var item in data)
        {

        }

    }

    [Benchmark]
    public void Queue()
    {
        var data = ExampleData.Queue();
        foreach (var item in data)
        {

        }

    }

    [Benchmark]
    public void Stack()
    {
        var data = ExampleData.Stack();
        foreach (var item in data)
        {

        }
    }


    [Benchmark]
    public void SortedDictionary()
    {
        var data = ExampleData.SortedDictionary();
        foreach (var item in data)
        {

        }
    }

    [Benchmark]
    public void SortedList()
    {
        var data = ExampleData.SortedList();
        foreach (var item in data)
        {

        }
    }

    [Benchmark]
    public void SortedSet()
    {
        var data = ExampleData.SortedSet();
        foreach (var item in data)
        {

        }
    }

    [Benchmark]
    public void LinkedList()
    {
        var data = ExampleData.LinkedList();
        foreach (var item in data)
        {

        }
    }
    [Benchmark]
    public void HashSet()
    {
        var data = ExampleData.HashSet();
        foreach (var item in data)
        {

        }
    }
}
