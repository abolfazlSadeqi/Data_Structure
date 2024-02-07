using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Normal;

public class SortedListExample
{


    /// <summary>
    /// create a  SortedList (list Alphabet)
    /// include declare,set values,get data,Remove,union,....
    /// </summary>
    public void Example()
    {
        //declare 
        SortedList<int, string> ListAlphabet = new SortedList<int, string>();
        SortedList ListAlphabetwithGeneric = new SortedList();
        

        //set values
        ListAlphabet.Add(5, "C");
        ListAlphabet.Add(1, "A");
        ListAlphabet.Add(14, null);
        ListAlphabet.Add(11, "J");
        ListAlphabet.Add(7, "T");

        //set values
        ListAlphabetwithGeneric.Add(5, "C");
        ListAlphabetwithGeneric.Add(1, "A");
        ListAlphabetwithGeneric.Add(14, null);
        ListAlphabetwithGeneric.Add(11, "J");
        ListAlphabetwithGeneric.Add(7, "T");


        //get value by Key
        var b = ListAlphabet[11];

        //edit 
        ListAlphabet[11] = "44";


        //adds a new key-value if a key does not exists
        ListAlphabet[27] = "r";

        //declare with init value
        SortedList<int, string> ListAlphabetnew = new SortedList<int, string>() { { 4, "C" }, { 3, "A" }, { 10, "J" } };


        //get value
        foreach (var item in ListAlphabet) Console.WriteLine($"item={item}");


        foreach (var item in ListAlphabet) Console.WriteLine($"key={item.Key}, value={item.Value}");


        for (int i = 0; i < ListAlphabet.Count; i++) Console.WriteLine($"key={ListAlphabet.Keys[i]}, value={ListAlphabet.Values[i]}");


        Console.WriteLine($"item={ListAlphabet[14]}");

        //Get by index
        var _result = ListAlphabet.ElementAt(0);

        //Remove with key
        ListAlphabet.Remove(1);

        //Remove with Index
        ListAlphabet.RemoveAt(0);

    }
}
