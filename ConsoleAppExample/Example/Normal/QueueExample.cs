using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Normal;

public class QueueExample
{

    /// <summary>
    /// create a Queue (list Events)
    /// include declare,set values,get data
    /// </summary>
    public void Example()
    {

        //declare
        Queue<string> Events = new Queue<string>();

        //set value
        Events.Enqueue("Event1");
        Events.Enqueue("Event2");
        Events.Enqueue("Event3");

       

        //get data with Dequeue(get an item and remove it)
        Console.WriteLine($"value Dequeue={Events.Dequeue()}" );

        //get data with Peek(get an item and without remove)
        Console.WriteLine($"value Peek={Events.Peek()}");

        // get data
        foreach (var item in Events) Console.WriteLine($"value={item}");


        Events.Enqueue("Event5");
        // get data
        foreach (var item in Events) Console.WriteLine($"value after Enqueue={item}");

        Console.WriteLine($"Contains= {Events.Contains("Event3")}");

        Events.Clear();

        Console.WriteLine($"Count= {Events.Count}");


    }
}
