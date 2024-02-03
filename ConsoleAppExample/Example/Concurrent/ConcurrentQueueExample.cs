using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Concurrent;

public class ConcurrentQueueExample
{

    /// <summary>
    /// create a ConcurrentQueue (list Province)
    /// include declare,set values,get data
    /// </summary>
    public void Example()
    {
        // declare
        ConcurrentQueue<string> listProvince = new ConcurrentQueue<string>();

        // set value
        listProvince.Enqueue("Tehran");
        listProvince.Enqueue("Lorestan");
        listProvince.Enqueue("Gilan");


        // TryPeek:Tries to return an object from the beginning of the ConcurrentQueue<T> without removing it.
        
        listProvince.TryPeek(out string result);
        Console.WriteLine($"value={result}");


        // get value
        var action = () =>
        {
            // TryDequeue:Tries to remove and return the object at the beginning of the concurrent queue.

            listProvince.TryDequeue(out string value);
            Console.WriteLine($"value = {value}");

            listProvince.TryDequeue(out  value);
            Console.WriteLine($"value = {value}");


        };

       
        Parallel.Invoke(action);

    }
}
