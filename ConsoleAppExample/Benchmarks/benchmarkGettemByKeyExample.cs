﻿using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Benchmarks;
[MemoryDiagnoser(false)]
public class benchmarkGettemByKeyExample
{
    [Benchmark]
    public void Array()
    {

        int[] _data = new int[5];

        _data[0] = 1000;
        _data[1] = 45000;
        _data[2] = 5500;
        _data[3] = 7800;
        _data[4] = 44550;

        var b = _data.First(d => d == 5500);

    }

    [Benchmark]
    public void List()
    {

        List<int> _data = new List<int>();

        _data.Add(1000);
        _data.Add(45000);
        _data.Add(5500);
        _data.Add(7800);
        _data.Add(44550);

        var b = _data.First(d => d == 5500);
    }


    [Benchmark]
    public void Dictionary()
    {

        Dictionary<int, int> _data = new Dictionary<int, int>();

        _data[0] = 1000;
        _data[1] = 45000;
        _data[2] = 5500;
        _data[3] = 7800;
        _data[4] = 44550;

        var b = _data.First(d => d.Key == 2);
    }


    [Benchmark]
    public void Hashtable()
    {

        Hashtable _data = new Hashtable();

        _data[0] = 1000;
        _data[1] = 45000;
        _data[2] = 5500;
        _data[3] = 7800;
        _data[4] = 44550;
        var b = _data[2];

    }

    [Benchmark]
    public void Queue()
    {

        Queue<int> _data = new Queue<int>();

        _data.Enqueue(1000);
        _data.Enqueue(45000);
        _data.Enqueue(5500);
        _data.Enqueue(7800);
        _data.Enqueue(44550);

        _data.Dequeue();
        _data.Dequeue();
        _data.Dequeue();
    }

    [Benchmark]
    public void Stack()
    {

        Stack<int> _data = new Stack<int>();
        _data.Push(1000);
        _data.Push(45000);
        _data.Push(5500);
        _data.Push(7800);
        _data.Push(44550);


        _data.Pop();
        _data.Pop();

        _data.Pop();

    }


    [Benchmark]
    public void SortedDictionary()
    {

        SortedDictionary<int, int> _data = new SortedDictionary<int, int>();
        _data.Add(0, 1000);
        _data.Add(1, 45000);
        _data.Add(2, 5500);
        _data.Add(3, 7800);
        _data.Add(4, 44550);
        var b = _data[2];
    }

    [Benchmark]
    public void SortedList()
    {


        SortedList<int, int> _data = new SortedList<int, int>();
        _data.Add(0, 1000);
        _data.Add(1, 45000);
        _data.Add(2, 5500);
        _data.Add(3, 7800);
        _data.Add(4, 44550);
    }

    [Benchmark]
    public void SortedSet()
    {

        SortedSet<int> _data = new SortedSet<int>();
        _data.Add(1000);
        _data.Add(45000);
        _data.Add(5500);
        _data.Add(7800);
        _data.Add(44550);
        var b = _data.TryGetValue(5500, out int _);
    }

    [Benchmark]
    public void LinkedList()
    {

        LinkedList<int> _data = new LinkedList<int>();
        _data.AddLast(1000);
        _data.AddLast(45000);
        _data.AddLast(5500);
        _data.AddLast(7800);
        _data.AddLast(44550);

        var b = _data.Find(5500);
    }
    [Benchmark]
    public void HashSet()
    {

        HashSet<int> _data = new HashSet<int>();
        _data.Add(1000);
        _data.Add(45000);
        _data.Add(5500);
        _data.Add(7800);
        _data.Add(44550);
        var b = _data.TryGetValue(5500, out int _);
    }


}
