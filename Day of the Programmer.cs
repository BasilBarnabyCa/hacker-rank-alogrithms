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
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    { 
        int feb = 28;
        int days = 31 + 31 + 30 + 31 + 30 + 31 + 31;
        int day = 0;
        
        if(year < 1918) {
            if(year % 4 == 0) {
                feb = 29;
            } 
        } else if(year > 1918) {
            if(year % 400 == 0 || year % 4 == 0 && year % 100 > 0) {
                feb = 29;
            }
        }
        
        if(year == 1918) {
            day = 26;
        } else {
            day = 256 - (days + feb);
        }
        
        string date = day.ToString() + "." + "09." + year.ToString();
        
        return date;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
