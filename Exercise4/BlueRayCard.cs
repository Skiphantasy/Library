/*
 * EXERCISE.............: Exercise 4.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP ........: 2º Interface Development 
 * TITLE : Classes design. Hierarchy and Polymorphism
 * DEADLINE..... 14 Nov 2018
 */


using System;
using System.Collections.Generic;
using Utilities;

namespace Exercise4
{
    class BlueRayCard : Card
    {
        #region variables
        string director;
        int year;
        List<string> actors;
        #endregion
        #region constructor
        public BlueRayCard(string reference, string title, 
            int copyNo, string director, int year, List<string> actors) : base(reference, title, copyNo)
        {
            this.director = director;
            this.year = year;
            this.actors = actors;
        }
        public override void Print(string[] language)
        {
            Options.Print(ConsoleColor.Cyan, "\n" + language[11] + base.Reference + "\n");
            Options.Print(ConsoleColor.Cyan, language[12] + base.Title + "\n");
            Options.Print(ConsoleColor.Cyan, language[18] + base.CopyNo + "\n");
            Options.Print(ConsoleColor.Cyan, language[13] + director + "\n");
            Options.Print(ConsoleColor.Cyan, language[14] + year + "\n");
            Options.Print(ConsoleColor.Cyan, language[25]);

            for (int i = 0; i < actors.Count; i++)
            {
                Options.Print(ConsoleColor.Cyan, actors[i] + ((i == (actors.Count - 1)) ? "\n\n" : ", "));              
            }
        }
        #endregion
        #region properties
        public string Director { get => director; }
        public int Year { get => year; }
        public List<string> Actors { get => actors; }
        #endregion
    }
}
