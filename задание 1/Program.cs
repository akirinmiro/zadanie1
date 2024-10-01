using System;
using System.Collections.Generic;
using System.Linq;

public class zadanie1
{
    public static void Main(string[] args)
    {
        
        List<int> sequenceA = new List<int> { 47, 21, 13, 55, 78 };
        List<int> sequenceB = new List<int> { 129, 47, 147, 85, 235 };

        
        var innerJoin = sequenceA
            .Join(sequenceB,
                a => a % 10, 
                b => b % 10, 
                (a, b) => $"{a}-{b}") 
            .ToList();

        
        Console.WriteLine("Внутреннее объединение:");
        foreach (var item in innerJoin)
        {
            Console.WriteLine(item);
        }
    }
}
