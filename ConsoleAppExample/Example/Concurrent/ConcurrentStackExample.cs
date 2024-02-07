using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Concurrent;

public class ConcurrentStackExample
{

    /// <summary>
    /// create a ConcurrentStack (list Province)
    /// include declare,set values,get data
    /// </summary>
    public async void Example()
    {
        // declare
        ConcurrentStack<string> ListProvince = new ConcurrentStack<string>();
        

   //set value 
   Task producer = Task.Run(() =>
        {

            ListProvince.Push("Tehran");
            ListProvince.Push("Lorestan");
            ListProvince.Push("Gilan");
        });


        // Run 
        Task.WaitAll(producer);


        //TryPeek:Attempts to return an object from the top of the ConcurrentStack<T> without removing it.

        ListProvince.TryPeek(out string resultTryPeek);
        Console.WriteLine($"TryPeek= {resultTryPeek} ");


     

        //IsEmpty
        Console.WriteLine($"IsEmpty={ListProvince.IsEmpty}");


        // get value

        Task consumer = Task.Run(() =>
        {
            string item;
            //TryPop:Attempts to pop and return the object at the top of the ConcurrentStack<T>.
            ListProvince.TryPop(out item);
            Console.WriteLine($"TryPop= {item}");

            ListProvince.TryPop(out item);
            Console.WriteLine($"TryPop= {item}");


            ListProvince.TryPop(out item);
            Console.WriteLine($"TryPop= {item}");

            
        });


        await Task.WhenAll( consumer);

        //Get by index
        var _result = ListProvince.ElementAt(0);

        //Clear
        ListProvince.Clear();

    }
}
