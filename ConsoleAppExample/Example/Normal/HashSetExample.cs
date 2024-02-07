using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Normal;

public class HashSetExample
{

    /// <summary>
    /// create a HashSet (list number)
    /// include declare,set values,get data
    /// </summary>
    public void Example()
    {
        // declare
        HashSet<int> listkeyword = new HashSet<int>();
        
        //set value
        listkeyword.Add(100);
        listkeyword.Add(200);

        //Check Contains
        var b = listkeyword.Contains(100) ? (Nullable<int>) 100 : null;

        // Contains
        if (!listkeyword.Contains(100)) { }

        // get data
        foreach (var item in listkeyword) Console.WriteLine($" Value = {item}");

        //Get by index
        var _result = listkeyword.ElementAt(0);
    }

}
