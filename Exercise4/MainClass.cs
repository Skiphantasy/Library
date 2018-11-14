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
    class MainClass
    {
        #region variables
        static string[] language;
        static string title;
        static string reference;
        static string director;
        static int copyNo;
        static int year;
        static int number;
        static int volume;
        static string author;
        static string publisher;
        static List<string> actors;
        #endregion
        #region methods and voids
        static void Main(string[] args)
        {
            language = Options.SelectLanguage();
            actors = new List<string>();
            Console.WriteLine(language[23]);
            Console.ReadLine();
            string pressed;
            List<Card> library = new List<Card>();

            do
            {
                Console.Clear();
                ShowMenu();
                pressed = Console.ReadLine();

                switch (pressed)
                {
                    case "1":
                        BookCard book = createBookCard();                     
                        Options.Print(ConsoleColor.Cyan, "\n" + language[20] + "\n");
                        book.Print(language);
                        library.Add(book);
                        break;
                    case "2":
                        VolBookCard volBook = createVolBookCard();
                        Options.Print(ConsoleColor.Cyan, "\n" + language[20] + "\n");
                        volBook.Print(language);
                        library.Add(volBook);
                        break;
                    case "3":                        
                        MagazineCard magazine = createMagazineCard();
                        Options.Print(ConsoleColor.Cyan, "\n" + language[20] + "\n");
                        magazine.Print(language);
                        library.Add(magazine);
                        break;
                    case "4":
                        BlueRayCard blueRay = createBlueRayCard();
                        Options.Print(ConsoleColor.Cyan, "\n" + language[20] + "\n");
                        blueRay.Print(language);
                        library.Add(blueRay);
                        break;
                    case "5":
                        if(library.Count != 0)
                        {
                            for (int i = 0; i < library.Count; i++)
                            {
                                Options.Print(ConsoleColor.White, "---------------------");
                                library[i].Print(language);
                                Console.WriteLine();
                            }
                        } else
                        {
                            Console.WriteLine(language[26]);
                        }
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;                  
                    default:
                        Console.Clear();
                        ShowMenu();
                        Options.Print(ConsoleColor.Red, language[0] + "1 - 6\n");
                        break;
                }

                Console.WriteLine(language[23]);
                Console.ReadLine();
            } while (pressed != "6");
        }

        static BookCard createBookCard()
        {
            Console.WriteLine(language[10]);
            reference = Options.ReadString(language[11], 8, 3, language[1]);
            title = Options.ReadString(language[12], 15, 3, language[1]);
            copyNo = Options.ReadInt(language[18], 1000, 1, language[0]);
            author = Options.ReadString(language[17], 8, 3, language[1]);
            publisher = Options.ReadString(language[15], 10, 3, language[1]);

            return new BookCard(reference, title, copyNo, author, publisher);
        }

        static VolBookCard createVolBookCard()
        {
            Console.WriteLine(language[10]);
            reference = Options.ReadString(language[11], 8, 3, language[1]);
            title = Options.ReadString(language[12], 15, 3, language[1]);
            copyNo = Options.ReadInt(language[18], 1000, 1, language[0]);
            author = Options.ReadString(language[17], 8, 3, language[1]);
            publisher = Options.ReadString(language[15], 10, 3, language[1]);
            volume = Options.ReadInt(language[16], 1000, 3, language[1]);

            return new VolBookCard(reference, title, copyNo, author, publisher, volume);
        }

        static MagazineCard createMagazineCard()
        {
            Console.WriteLine(language[10]);
            reference = Options.ReadString(language[11], 8, 3, language[1]);
            title = Options.ReadString(language[12], 15, 3, language[1]);
            copyNo = Options.ReadInt(language[18], 1000, 1, language[0]);
            number = Options.ReadInt(language[19], 1000, 1, language[0]);
            year = Options.ReadInt(language[14], 2018, 1900, language[24]);

            return new MagazineCard(reference, title, copyNo, number, year); 
        }

        static BlueRayCard createBlueRayCard()
        {
            int actorsNo;
            Console.WriteLine(language[10]);
            reference = Options.ReadString(language[11], 8, 3, language[1]);
            title = Options.ReadString(language[12], 15, 3, language[1]);
            copyNo = Options.ReadInt(language[18], 1000, 1, language[0]);
            director = Options.ReadString(language[13], 15, 3, language[1]);
            year = Options.ReadInt(language[14], 2018, 1900, language[0]);
            actorsNo = Options.ReadInt(language[21], 25, 1, language[0]);

            for (int i = 0; i < actorsNo; i++)
            {
                string currentActor;
                Console.Write(language[22] + (i + 1) + "...: ");
                currentActor = Console.ReadLine();
                actors.Add(currentActor);
            }

            return new BlueRayCard(reference, title, copyNo, director, year, actors);
        }

        static void ShowMenu()
        {
            for (int i = 0; i < 7; i++)
            {
                Options.Print(ConsoleColor.Gray,language[(i + 3)]+ "\n");
            }

            Console.WriteLine();
        }
    }
    #endregion
}
