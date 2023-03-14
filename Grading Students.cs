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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> revisedGrades = new List<int>();
        
        for(int i = 0; i < grades.Count; i++) {
           if(grades[i] > 40 - 3) {
                if(grades[i] % 5 > 0) {
                    int gradeBase = grades[i] - (grades[i] % 5) + 5;
                    int gradeDiff = gradeBase - grades[i];
                    if(gradeDiff < 3) {
                        grades[i] = gradeBase;
                    }
                }
            }
            revisedGrades.Add(grades[i]);
        }

		// USING A FOREACH
		/*
		foreach(int grade in grades) {
           if(grade > 40 - 3) {
                if(grade % 5 > 0) {
                    int gradeBase = grade - (grade % 5) + 5;
                    int gradeDiff = gradeBase - grade;
                    if(gradeDiff < 3) {
                        grade = gradeBase;
                    }
                }
            }
            revisedGrades.Add(grade);
        }
		*/
	
        
        return revisedGrades;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
