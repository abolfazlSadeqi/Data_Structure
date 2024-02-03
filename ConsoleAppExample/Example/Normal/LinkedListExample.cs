using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Normal;

public class LinkedListExample
{
    /// <summary>
    /// Create LinkedList 
    /// Get Data and Remove Data
    /// </summary>
    public void Example()
    {


        //declare
        LinkedList<string> linkedListCoutry = new LinkedList<string>();

        //set values
        linkedListCoutry.AddLast("Iran");
        linkedListCoutry.AddLast("India");
        linkedListCoutry.AddLast("turkish");


        LinkedListNode<string> USANode = linkedListCoutry.AddLast("USA");

        //Get Data
        foreach (var item in linkedListCoutry) Console.WriteLine($"value: {item}");



        //Remove with different ways
        linkedListCoutry.Remove(USANode);
        linkedListCoutry.RemoveFirst();
        linkedListCoutry.RemoveLast();
        linkedListCoutry.Clear();


        //count
        Console.WriteLine($"Count: {linkedListCoutry.Count}");

    }
}
