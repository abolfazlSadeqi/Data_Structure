namespace ConsoleAppExample.Example.Normal;

public class SortedDictionaryExample
{
    /// <summary>
    /// create a  SortedDictionary (list Alphabet)
    /// include declare,set values,get data,Remove,union,....
    /// </summary>
    public void Example()
    {


        //declare
        SortedDictionary<int, string> ExampleAlphabet = new SortedDictionary<int, string>();

        //set value
        ExampleAlphabet.Add(1, "A");
        ExampleAlphabet.Add(3, "B");
        ExampleAlphabet.Add(2, "C");
        ExampleAlphabet.Add(5, "D");
        ExampleAlphabet.Add(4, "F");

        //get value
        foreach (var item in ExampleAlphabet) Console.WriteLine($"Key={item.Key}, Value={item.Value}");

        Console.WriteLine($"Value={ExampleAlphabet[2]}");

        //Count
        Console.WriteLine($"Count={ExampleAlphabet.Count}");

        //ContainsKey
        if (!ExampleAlphabet.ContainsKey(1)) { }


        // get values
        SortedDictionary<int, string>.ValueCollection valueColl = ExampleAlphabet.Values;
        foreach (var item in valueColl) Console.WriteLine($"Value = {item}");


        // get keys
        SortedDictionary<int, string>.KeyCollection keyColl = ExampleAlphabet.Keys;
        foreach (var item in keyColl) Console.WriteLine($"Key = {item}");

        //remove with key
        ExampleAlphabet.Remove(1);


    }
}
