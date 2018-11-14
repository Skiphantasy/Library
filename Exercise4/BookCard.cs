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
    class BookCard : Card
    {
        #region variables
        string author;
        string publisher;
        #endregion
        #region constructor
        public BookCard(string reference, string title, int copyNo, 
            string author, string publisher) : base(reference, title, copyNo)
        {
            this.author = author;
            this.publisher = publisher;
        }
        #endregion
        #region methods
        public override void Print(string[] language)
        {
            Options.Print(ConsoleColor.Cyan, "\n" + language[11] + base.Reference + "\n");
            Options.Print(ConsoleColor.Cyan, language[12] + base.Title + "\n");
            Options.Print(ConsoleColor.Cyan, language[18] + base.CopyNo + "\n");
            Options.Print(ConsoleColor.Cyan, language[17] + author + "\n");
            Options.Print(ConsoleColor.Cyan, language[15] + publisher + "\n\n");
        }
        #endregion
        #region properties
        public string Author { get => author; }
        public string Publisher { get => publisher; }
        #endregion
    }
}
