using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Normal;

public class StackExample
{

    /// <summary>
    /// create a Stack (list tests)
    /// include declare,set values,get data
    /// </summary>
    public void Example()
    {
        // declare
        Stack<string> listexample = new Stack<string>();

        //set values
        listexample.Push("test1");
        listexample.Push("test2");
        listexample.Push("test3");


        /// get  an item  with removing it
        Console.WriteLine($"Pop={listexample.Pop()}");

        /// get  an item  without removing it
        Console.WriteLine($"Peek={listexample.Peek()}");

        //get value
        foreach (var item in listexample)
            Console.WriteLine($"value={item}");

        listexample.Push("test5");

        //get value
        foreach (var item in listexample)
            Console.WriteLine($"value after Push={item}");

        //count
        Console.WriteLine($"Count:    {listexample.Count}");

        //Get by index
        var _result = listexample.ElementAt(0);

        listexample.Clear();


    }

}
