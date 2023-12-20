using System;

namespace Christmas_Tree // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number for lines: ");

            int totalRows = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int rowCount = 0; rowCount < totalRows; rowCount++)
            {
                for (int spaceCount = 0; spaceCount < totalRows - rowCount; spaceCount++)
                {                                                              //print a bunch of spaces
                    Console.Write("  ");                                        //print a bunch of spaces
                }                                                              //print a bunch of spaces

                for (int starCount = 0; starCount <= rowCount * 2; starCount++)//print a bunch of stars
                {                                                              //print a bunch of stars
                    Console.Write("* ");                                       //print a bunch of stars
                }
                Console.WriteLine();
            }
        }
    }
}