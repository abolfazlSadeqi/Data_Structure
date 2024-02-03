using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Concurrent;

public class ConcurrentBagExample
{

    /// <summary>
    /// create a ConcurrentBag (list numbers)
    /// include declare,set values,get data
    /// </summary>
    public void ExampleWithTask()
    {

        // declare
        ConcurrentBag<int> ExampleTask = new ConcurrentBag<int>();


        //set value 
        Task producer = Task.Run(() =>
        {
            ExampleTask.Add(10);
            ExampleTask.Add(14);
            ExampleTask.Add(13);
            ExampleTask.Add(14);
            ExampleTask.Add(13);

        });

        //get value 
        Task consumer = Task.Run(async () =>
        {
            foreach (var item in ExampleTask)
                Console.WriteLine($"ExampleWithTask,value= {item}");

        });

        Task.WaitAll(producer, consumer);
    }

    public void Example()
    {
       
        //declare
        ConcurrentBag<string> listCountry = new ConcurrentBag<string> { "Iran", "US", "Turkish", };

        //get value
        foreach (var item in listCountry) Console.WriteLine($"value={item} ");


        //TryTake:Attempts to remove and return an object from the ConcurrentBag<T>.
        listCountry.TryTake(out string ResultTryTake);
        Console.WriteLine($"Example,ResultTryTake = {ResultTryTake}");


        //TryPeek:Attempts to return an object from the ConcurrentBag<T> without removing it.

        listCountry.TryPeek(out string ResultTryPeek);
        Console.WriteLine($"Example,ResultTryPeek : {ResultTryPeek}");



        foreach (var item in listCountry)   Console.WriteLine($"Example,item={item} ");

        //Count
        Console.WriteLine($"Example, Count= {listCountry.Count}");

        //Clear
        listCountry.Clear();

    }
}