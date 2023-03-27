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
     * Complete the 'chessboardGame' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x
     *  2. INTEGER y
     */

    public static string chessboardGame(int x, int y)
    {
        x--;
        y--;
        
        if(( x / 2 ) % 2 == 0 && ( y / 2 ) % 2 == 0) {
            return "Second";
        } else {
            return "First";
        }
        
        
        // The code below worked for 2 of the 3 cases. I think it can be tweaked to be accurate
        // int xMin = 1;
        // int xMax = 15;
        // int yMin = 1;
        // int yMax = 15;
        
        // if(x - 1 < xMin || x - 2 < xMin || x + 1 > xMax || y - 1 < yMin || y - 2 < yMin || y + 1 > yMax) {
        //     return "Second";
        // } else {
        //     return "First";
        // }
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x = Convert.ToInt32(firstMultipleInput[0]);

            int y = Convert.ToInt32(firstMultipleInput[1]);

            string result = Result.chessboardGame(x, y);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
