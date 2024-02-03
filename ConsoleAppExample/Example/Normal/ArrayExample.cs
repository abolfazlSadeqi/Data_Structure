using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample.Example.Normal;

public class ArrayExample
{
    /// <summary>
    /// create a single dimensional
    /// you can declare a array with two ways
    /// </summary>
    /// <returns></returns>
    public int[] Example_single_dimensional()
    {
        // Declare Way 1
        int[] Example1 = new int[3];
        Example1[0] = 7;
        Example1[1] = 10;
        Example1[2] = 15;

        // Declare Way 2 with set values
        // int[] Example1 = [7, 10, 15];

        foreach (var item in Example1)
            Console.WriteLine($"Value: {item}");
        return Example1;
    }

    /// <summary>
    /// create a multi Dimensional
    /// you can declare a array with two ways
    /// </summary>
    /// <returns></returns>
    public void Example_multiDimensional()
    {

        // Declare a two dimensional array.
        int[,] example1 = new int[4, 2];

        // Declare and set array element values.
        int[,] example2 = { { 10, 14, 15, 17 }, { 147, 100, 105, 174 } };


        //Get Data with Way 1
        foreach (var item in example2)
            Console.WriteLine($"Value: {item}");

        //Get Data with Way 2
        for (int i = 0; i < example2.GetLength(0); i++)
        {
            for (int j = 0; j < example2.GetLength(1); j++)
            {
                Console.WriteLine($"Value: {example2[i, j]}");
            }
        }

    }
    /// <summary>
    /// create a Jagged
    /// you can declare a array with two ways
    /// </summary>
    public void Example_Jagged()
    {

        // Declare a jagged array.
        int[][] example = new int[3][];

        // Set the values 
        // example[0] = [1, 2, 3, 4];


        int[][] example2 = new int[][]
            {
                new int[] { 150, 10, 24 },
                new int[] { 140 },
                new int[] { 500,14,22 }
            };

        //Get Data with Way 1
        foreach (var item in example2)
        {
            foreach (int value in item)
            {
                Console.WriteLine($"Value: {value}");
            }
        }

       
    }
}
