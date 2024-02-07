using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Normal;

public class ListExample
{
    /// <summary>
    /// create a List (list skills)
    /// include declare,set values,get data
    /// </summary>
    public void Example()
    {
        //declare
        List<string> Exampleskills1 = new List<string>();

        //declare with init value
        List<string> Exampleskills2 = new List<string>() { "C#", "sql","DDD" };

        
        //set values
        Exampleskills1.Add("C#");
        Exampleskills1.Add("sql");
        Exampleskills1.Add("DDD");

        //insert 
        Exampleskills1.Insert(3, "js");

        

        // get data with way 1 
        for (int i = 0; i < Exampleskills2.Count; i++)
        Console.WriteLine($"value: {Exampleskills2[i]}");


        // get data with way 2 
        foreach (var item in Exampleskills2)
            Console.WriteLine($"value: {item}");

        //remove
        Exampleskills2.RemoveAt(0);
        Exampleskills2.Remove("DDD");


    }
}
