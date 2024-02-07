using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Concurrent;

public class ConcurrentDictionaryExample
{

    /// <summary>
    /// create a ConcurrentDictionary (list numbers)
    /// include declare,set values,get data
    /// </summary>
    public void Example()
    {
        // declare
        ConcurrentDictionary<int, string> TypeFile = new ConcurrentDictionary<int, string>(1, 100);

        //set value 
        TypeFile.TryAdd(1, "Pdf");
        TypeFile.TryAdd(2, "doc");
        TypeFile.TryAdd(3, "excel");

        //get value by Key
        var b = TypeFile[1];

        //Edit value
        TypeFile[1] = "ss";

        //get value

        foreach (var item in TypeFile)
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

        //Get by index
        var _result = TypeFile.ElementAt(0);
    }
}
