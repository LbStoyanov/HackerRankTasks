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

    public static string timeConversion(string? s)
    {
        //Given a time in -hour AM/PM format, convert it to military (24-hour) time.
        //Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        //- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.


        //INPUT: 07:05:45PM
        //OUTPUT: 19:05:45

        DateTime d = DateTime.Parse(s);
       

        return d.ToString("HH:mm:ss");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("Desktop", true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);
        //Console.WriteLine(result);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}