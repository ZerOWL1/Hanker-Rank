using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int i2 = int.Parse(Console.ReadLine());
        double d2 = double.Parse(Console.ReadLine());
        string s2 = Console.ReadLine();
        // Read and save an integer, double, and String to your variables.
        int sumInt = i + i2;
        double sumDouble = (double)d + d2;
        string sumString = s + s2;
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(sumInt);
        // Print the sum of the double variables on a new line.
        string doub = String.Format("{0:0.0}", sumDouble);
        Console.WriteLine(doub);
        // Concatenate and print the String variables on a new line
        Console.WriteLine(sumString);
        // The 's' variable above should be printed first.

    }
}
