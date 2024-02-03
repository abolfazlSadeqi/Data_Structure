using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Benchmarks;

public class ExampleData
{
    public const int Length = 4;
    
    public static int[] ExampleDatas()
    {
        Random rnd = new Random(12839);
        List<int> list = new List<int>();

        for (int i = 0; i < Length; ++i)
        {
            list.Add(rnd.Next());
        }

        return list.ToArray();
    }



    public static int[] Array()
    {
        var data = ExampleData.ExampleDatas();
        int[] _data = new int[Length];

        for (int i = 0; i < Length ; ++i)
        {
            _data[i] = data[i];
        }
        return _data;

    }


    public static List<int> List()
    {
        var data = ExampleData.ExampleDatas();
        List<int> _data = new List<int>();

        for (int i = 0; i < Length ; ++i)
        {
            _data.Add(data[i]);
        }

        return _data;


    }



    public static Dictionary<int, int> Dictionary()
    {
        var data = ExampleData.ExampleDatas();
        Dictionary<int, int> _data = new Dictionary<int, int>();

        for (int i = 0; i < Length ; ++i)
        {
            _data.Add(i, data[i]);
        }
        return _data;

    }



    public static Hashtable Hashtable()
    {
        var data = ExampleData.ExampleDatas();
        Hashtable _data = new Hashtable();
        for (int i = 0; i < Length ; ++i)
        {
            _data.Add(i, data[i]);
        }
        return _data;
    }

    public static Queue<int> Queue()
    {
        var data = ExampleData.ExampleDatas();
        Queue<int> _data = new Queue<int>();
        for (int i = 0; i < Length ; ++i)
        {
            _data.Enqueue(data[i]);
        }
        return _data;

    }


    public static Stack<int> Stack()
    {
        var data = ExampleData.ExampleDatas();
        Stack<int> _data = new Stack<int>();
        for (int i = 0; i < Length ; ++i)
        {
            _data.Push(data[i]);
        }

        return _data;
    }



    public static SortedDictionary<int, int> SortedDictionary()
    {
        var data = ExampleData.ExampleDatas();
        SortedDictionary<int, int> _data = new SortedDictionary<int, int>();

        for (int i = 0; i < Length ; ++i)
        {
            _data.Add(i, data[i]);
        }
        return _data;
    }


    public static SortedList<int, int> SortedList()
    {
        var data = ExampleData.ExampleDatas();
        SortedList<int, int> _data = new SortedList<int, int>();

        for (int i = 0; i < Length ; ++i)
        {
            _data.Add(i, data[i]);
        }
        return _data;
    }


    public static SortedSet<int> SortedSet()
    {
        var data = ExampleData.ExampleDatas();
        SortedSet<int> _data = new SortedSet<int>();

        for (int i = 0; i < Length ; ++i)
        {
            _data.Add(data[i]);
        }
        return _data;
    }


    public static LinkedList<int> LinkedList()
    {
        var data = ExampleData.ExampleDatas();
        LinkedList<int> _data = new LinkedList<int>();

        for (int i = 0; i < Length ; ++i)
        {
            _data.AddLast(data[i]);
        }

        return _data;
    }

}
