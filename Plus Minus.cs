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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double positiveNumbers = 0;
        double negativeNumbers = 0;
        double zeroNumbers = 0;
        
        for(int i = 0; i < arr.Count; i++){
            if(arr[i] < 0) {
                negativeNumbers += 1;
            } else if(arr[i] == 0) {
                zeroNumbers += 1;
            } else {
                positiveNumbers += 1;
            }
        }
        
        double positiveRatio = positiveNumbers/arr.Count;
        double negativeRatio = negativeNumbers/arr.Count;
        double zeroRatio = zeroNumbers/arr.Count;
        
        Console.WriteLine("{0:N6}", positiveRatio);
        Console.WriteLine("{0:N6}", negativeRatio);
        Console.WriteLine("{0:N6}", zeroRatio);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
