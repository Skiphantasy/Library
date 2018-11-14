/*
 * EXERCISE.............: Exercise 4.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP ........: 2º Interface Development 
 * TITLE : Classes design. Hierarchy and Polymorphism
 * DEADLINE..... 14 Nov 2018
 */

namespace Exercise4
{
    abstract class Card
    {
        #region variables
        string reference;
        string title;
        int copyNo;
        static int orderNo;
        #endregion
        #region constructor
        public Card(string reference, string title, int copyNo)
        {
            orderNo++;
            this.reference = reference + "/" + orderNo;
            this.title = title;
            this.copyNo = copyNo;
        }
        #endregion
        #region methods
        public abstract void Print(string[] language);
        #endregion
        #region properties
        public string Reference { get => reference; set => reference = value; }
        public string Title { get => title; }
        public int CopyNo { get => copyNo; }
        public int OrderNo { get => orderNo; }
        #endregion       
    }
}
