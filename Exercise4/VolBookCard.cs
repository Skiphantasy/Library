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
    class VolBookCard : BookCard
    {
        #region variables
        int volume;
        #endregion
        #region constructor
        public VolBookCard(string reference, string title, int copyNo, 
            string author, string publisher,int volume) : base(reference, title, copyNo, author, publisher)
        {
            this.volume = volume;
        }
        #endregion
        #region methods
        public override void Print(string[] language)
        {
            Options.Print(ConsoleColor.Cyan, "\n" + language[11] + base.Reference + "\n");
            Options.Print(ConsoleColor.Cyan, language[12] + base.Title + "\n");
            Options.Print(ConsoleColor.Cyan, language[18] + base.CopyNo + "\n");
            Options.Print(ConsoleColor.Cyan, language[17] + base.Author + "\n");
            Options.Print(ConsoleColor.Cyan, language[15] + base.Publisher + "\n");
            Options.Print(ConsoleColor.Cyan, language[16] + volume + "\n\n");
        }
        #endregion
    }
}
