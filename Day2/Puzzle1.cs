using System;
using System.Linq;
					
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
                int.TryParse(minMaxSplit[0], out int minLimit);
                int.TryParse(minMaxSplit[1], out int maxLimit);

                char letterToCheck = splitArray[1].ToCharArray()[0];

                string pw = splitArray[2];

                var occurredCt = pw.Count(c => c == letterToCheck);
                if(occurredCt >= minLimit && occurredCt <= maxLimit)
                {
                    validPw++;
                }
            }

            System.Console.Write(validPw);
        }
}