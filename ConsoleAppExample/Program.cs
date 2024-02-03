using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using ConsoleAppExample.Benchmarks;
using ConsoleAppExample.Example.Concurrent;
using ConsoleAppExample.Example.Normal;


BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, new DebugInProcessConfig());

System.Diagnostics.Debugger.Launch();
var summary = BenchmarkRunner.Run<benchmarkGettemByKeyExample>();

Console.WriteLine("arrayExample");
Console.WriteLine("-");

ArrayExample arrayExample = new ArrayExample();
arrayExample.Example_single_dimensional();
arrayExample.Example_multiDimensional();
arrayExample.Example_Jagged();

Console.WriteLine("dictionaryExample");
Console.WriteLine("-");

DictionaryExample dictionaryExample = new DictionaryExample();
dictionaryExample.Example();
dictionaryExample.Example2();

Console.WriteLine("hashtableExample");
Console.WriteLine("-");

hashtableExample hashtableExample = new hashtableExample();
hashtableExample.Example();

Console.WriteLine("LinkedListExample");
Console.WriteLine("-");

LinkedListExample LinkedListExample = new LinkedListExample();
LinkedListExample.Example();



Console.WriteLine("ListExample");
Console.WriteLine("-");

ListExample ListExample = new ListExample();
ListExample.Example();


Console.WriteLine("SortedDictionaryExample");
Console.WriteLine("-");

SortedDictionaryExample SortedDictionaryExample = new SortedDictionaryExample();
SortedDictionaryExample.Example();


Console.WriteLine("SortedListExample");
Console.WriteLine("-");

SortedListExample SortedListExample = new SortedListExample();
SortedListExample.Example();


Console.WriteLine("sortedsetExample");
Console.WriteLine("-");

sortedsetExample sortedsetExample = new sortedsetExample();
sortedsetExample.Example();


Console.WriteLine("StackExample");
Console.WriteLine("-");

StackExample StackExample = new StackExample();
StackExample.Example();


Console.WriteLine("QueueExample");
Console.WriteLine("-");

QueueExample QueueExample = new QueueExample();
QueueExample.Example();


Console.WriteLine("blockingcollectionExample");
Console.WriteLine("-");

blockingcollectionExample blockingcollectionExample = new blockingcollectionExample();
blockingcollectionExample.Example1();
blockingcollectionExample.ExampleWithTask();


Console.WriteLine("ConcurrentBagExample");
Console.WriteLine("-");

ConcurrentBagExample ConcurrentBagExample = new ConcurrentBagExample();
ConcurrentBagExample.Example();
ConcurrentBagExample.ExampleWithTask();


Console.WriteLine("ConcurrentDictionaryExample");
Console.WriteLine("-");

ConcurrentDictionaryExample ConcurrentDictionaryExample = new ConcurrentDictionaryExample();
ConcurrentDictionaryExample.Example();



Console.WriteLine("ConcurrentQueueExample");
Console.WriteLine("-");

ConcurrentQueueExample ConcurrentQueueExample = new ConcurrentQueueExample();
ConcurrentQueueExample.Example();


Console.WriteLine("ConcurrentStackExample");
Console.WriteLine("-");

ConcurrentStackExample ConcurrentStackExample = new ConcurrentStackExample();
ConcurrentStackExample.Example();