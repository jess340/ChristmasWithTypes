using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thursday;

            //TODO set Santa's name to Kris Kringle
            string santaName = "Kris Kringle";
            xmas.Santa = santaName;

            //TODO Insert 3 presents you would like for xmas.  They must be strings
            xmas.Presents =  new string[3]{"sandals", "bracelet", "makeup" };

            //TODO Set the TreeHeight to 10
            int treeHeight = 10;
            xmas.TreeHeight = treeHeight;
        }
    }
}
