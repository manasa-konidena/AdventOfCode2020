using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
        public static void Main()
        {
            int validPw = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"/Users/manasakonidena/Documents/Github/AdventOfCode2020/Day2/day2puzzle1input.txt");
            while ((line = file.ReadLine()) != null)
            {
                var splitArray = line.Split(' ');
                var minMaxSplit = splitArray[0].Split('-');
                int.TryParse(minMaxSplit[0], out int pos1);
                int.TryParse(minMaxSplit[1], out int pos2);

                char letterToCheck = splitArray[1].ToCharArray()[0];

                string pw = splitArray[2];

                var foundIndexes = new List<int>();

                for (int i = 0; i < pw.Length; i++)
                {
                    if (pw[i] == letterToCheck) 
                    {
                        foundIndexes.Add(i);
                    }
                }

                if((foundIndexes.Contains(pos1 - 1) && !foundIndexes.Contains(pos2 - 1))
                || (!foundIndexes.Contains(pos1 - 1) && foundIndexes.Contains(pos2 - 1)))
                {
                    validPw++;
                }

            }

            System.Console.Write(validPw);
        }
}