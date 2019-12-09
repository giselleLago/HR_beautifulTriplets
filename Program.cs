using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the beautifulTriplets function below.
    static int beautifulTriplets(int d, int[] arr)
    {
        var contBTriplet = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if ( arr[k] - arr[j] == d && arr[j] - arr[i] == d)
                    {
                        contBTriplet++;
                    }
                }
            }
        }
        return contBTriplet;
    }

    static void Main(string[] args)
    {

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = beautifulTriplets(d, arr);

        Console.WriteLine(result);
        Console.ReadKey();

    }
}
