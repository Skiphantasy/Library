/*
 * EXERCISE.............: Exercise 4.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP ........: 2º Interface Development 
 * TITLE : Classes design. Hierarchy and Polymorphism
 * DEADLINE..... 14 Nov 2018
 */


using System;
using Utilities;

namespace Exercise4
{
    class MagazineCard :Card
    {
        #region variables
        int number;
        int year;
        #endregion
        #region constructor
        public MagazineCard(string reference, string title,
            int copyNo, int number, int year) : base(reference, title, copyNo)
        {
            this.number = number;
            this.year = year;
        }
        #endregion
        #region methods
        public override void Print(string[] language)
        {
            Options.Print(ConsoleColor.Cyan, "\n" + language[11] + base.Reference + "\n");
            Options.Print(ConsoleColor.Cyan, language[12] + base.Title + "\n");
            Options.Print(ConsoleColor.Cyan, language[18] + base.CopyNo + "\n");
            Options.Print(ConsoleColor.Cyan, language[19] + number + "\n");
            Options.Print(ConsoleColor.Cyan, language[14] + year + "\n\n");
        }
        #endregion
        #region properties
        public int Number { get => number; }
        public int Year { get => year; }
        #endregion
    }
}
