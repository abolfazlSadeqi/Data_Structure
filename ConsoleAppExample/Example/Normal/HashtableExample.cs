using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Normal;

public class hashtableExample
{

    /// <summary>
    /// create a Hashtable (list keyword)
    /// include declare,set values,get data
    /// </summary>
    public void Example()
    {
        // declare
        Hashtable listkeyword = new Hashtable();

        //set value
        listkeyword.Add("sql", "select,from,join");
        listkeyword.Add("C#", "class,static");
        listkeyword["js"] = "from";

        Console.WriteLine($"value ={listkeyword["js"]}");

        // ContainsKey 
        if (!listkeyword.ContainsKey("C#")) { }

        // get data
        foreach (DictionaryEntry item in listkeyword) Console.WriteLine($"Key = {item.Key}, Value = {item.Value}");

        // get Values
        ICollection valueColl = listkeyword.Values;

        foreach (var item in valueColl) Console.WriteLine($"Value = {item}");


        // get Keys
        ICollection keyColl = listkeyword.Keys;

        foreach (var key in keyColl) Console.WriteLine($"Key = {key}");
    }

}
