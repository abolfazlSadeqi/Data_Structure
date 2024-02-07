using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Normal;

public class DictionaryExample
{
    /// <summary>
    /// create a Dictionary (list students)
    /// include declare,set values,get data
    /// </summary>
    public void Example()
    {
        //declare
        IDictionary<int, string> students = new Dictionary<int, string>();

        //set values
        students.Add(1, "a1");
        students.Add(2, "a2");
        students.Add(3, "b4");

        //get by key
        var b = students[2];
        //Edit
        students[2] = "44";

        //Get by index
        var _result=students.ElementAt(0);

        //get data
        foreach (var item in students)
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

    }

    /// <summary>
    /// create a Dictionary (list province)
    /// include declare,set values,get data
    /// </summary>
    public void Example2()
    {
        //declare and init value
        var province = new Dictionary<string, string>(){
            {"Iran", "Tehran, Qilan, hamedan"},
            {"Turkey", "Adana, Bitlis, İzmir"}
        };


        //set values
        foreach (var item in province)
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

    }
}
