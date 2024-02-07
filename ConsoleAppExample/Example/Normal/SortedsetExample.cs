using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Normal;

public class sortedsetExample
{


    /// <summary>
    /// create a sortedset (list Province)
    /// include declare,set values,get data,Remove,union,....
    /// </summary>
    public void Example()
    {
        //declare
        SortedSet<string> sortedSetProvinces = new SortedSet<string>();
       


        //set values

        sortedSetProvinces.Add("Tehran");
        sortedSetProvinces.Add("hamedan");
        sortedSetProvinces.Add("Guilan");
        sortedSetProvinces.Add("lorestan");

        //declare with init value
        SortedSet<string> sortedSetProvinces2 = new SortedSet<string>() {"Tehran2","esfahan"};

        //get value
        var b = sortedSetProvinces.Contains("Guilan") ? "Guilan" : "";

        //get value
        foreach (var item in sortedSetProvinces) Console.WriteLine($"value={item}");


        //Contains
        Console.WriteLine($"Contains={sortedSetProvinces2.Contains("esfahan")}");

        //Count
        Console.WriteLine($"Count={sortedSetProvinces2.Count}");


        //Overlaps:Determines whether the current SortedSet<T> object and a specified collection share common elements.

        Console.WriteLine($"Overlaps={sortedSetProvinces.Overlaps(sortedSetProvinces2)}");

        ///SetEquals:Determines whether the current SortedSet<T> object and the specified collection contain the same elements.
        Console.WriteLine($"SetEquals={sortedSetProvinces.SetEquals(sortedSetProvinces2)}");

        //Get by index
        var _result = sortedSetProvinces.ElementAt(0);

        //Reverse
        var sortedSetProvincesReverse = sortedSetProvinces.Reverse();

        //get First value
        Console.WriteLine($"First={sortedSetProvinces.First()}");

        //get Last value
        Console.WriteLine($"Last={sortedSetProvinces.Last()}");


        //UnionWith
        sortedSetProvinces.UnionWith(sortedSetProvinces2);


        //ExceptWith
        sortedSetProvinces.ExceptWith(sortedSetProvinces2);


        //Remove
        sortedSetProvinces2.Remove("esfahan");

    }


}

