using ConsoleAppExample.Example.Normal;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Concurrent;

public class blockingcollectionExample
{

    /// <summary>
    /// create a blockingcollection (list numbers)
    /// include declare,set values,get data
    /// </summary>
    public void Example1()
    {
        // declare
        BlockingCollection<int> blockingExample = new BlockingCollection<int>(4);


        //set values with Add
        blockingExample.Add(14);
        blockingExample.Add(5);

        //set values with TryAdd
        blockingExample.TryAdd(10);
        blockingExample.TryAdd(13);

        //set values with TryAdd with use Timeout
        if (blockingExample.TryAdd(140, TimeSpan.FromSeconds(1))) { }


        //get value
        foreach (var item in blockingExample) Console.WriteLine($"Example1,value ={item}");

    }

    public void ExampleWithTask()
    {

        // declare
        BlockingCollection<int> ExampleTask = new BlockingCollection<int>(10);

        //set value 
        Task producer = Task.Run(() =>
        {
            ExampleTask.Add(10);
            ExampleTask.Add(14);
            ExampleTask.Add(13);
            ExampleTask.Add(14);
            ExampleTask.Add(13);

            ExampleTask.CompleteAdding();
        });

        //get value 
        Task consumer = Task.Run(() =>
        {
            foreach (var item in ExampleTask.GetConsumingEnumerable())
                Console.WriteLine($"ExampleTask,value= {item}");

        });

        Task.WaitAll(producer, consumer);
    }
}
