using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
        public static void Main()
        {
            List<int> listOfSlopeRights = new List<int>{1,3,5,7,1};
            long productEnd = 1;
            int loopCt = 0;

            foreach(var right in listOfSlopeRights)
            {
                loopCt++;
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
                    if(currentLine % 2 == 0 && loopCt == listOfSlopeRights.Count)
                    {
                        currentLine++;
                        continue;
                    }
                    if(offset + right >= line.Length)
                    {
                        offset = offset + right - line.Length;
                    }
                    else
                    {
                        offset = offset + right;
                    }
                    if(line[offset] == '#')
                    {
                        numTrees++;
                    }
                    currentLine++;
                }
                productEnd = productEnd*numTrees;

                System.Console.WriteLine("TreeCount" + numTrees);

            }

            System.Console.WriteLine("Final Product" + productEnd);
            
        }
}