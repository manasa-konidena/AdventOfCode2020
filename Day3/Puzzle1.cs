using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
        public static void Main()
        {
            int numTrees = 0;
            string line;
            int offset = 0;
            int currentLine = 1;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"/Users/manasakonidena/Documents/Github/AdventOfCode2020/Day3/day3input.txt");
            while ((line = file.ReadLine()) != null)
            {
                if(currentLine == 1)
                {
                    currentLine++;
                    continue;
                }
                if(offset + 3 >= line.Length)
                {
                    offset = offset + 3 - line.Length;
                }
                else
                {
                    offset = offset + 3;
                }
                if(line[offset] == '#')
                {
                    numTrees++;
                }
                currentLine++;
            }

            System.Console.WriteLine(numTrees);
        }
}