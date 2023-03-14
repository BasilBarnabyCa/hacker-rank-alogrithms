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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string [] timeString = s.Split(":");
        int hour = int.Parse(timeString[0]);
        string armyTime = "";
        int hourString = 0;

        if(timeString[2].Substring(2) == "PM") {
            hourString = (hour % 12) + 12;
        } else {
            hourString = hour % 12;
        }
    
        return armyTime = string.Format("{0:00}", hourString)
            + ":" + timeString[1] + ":" + timeString[2].Substring(0, 2);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
