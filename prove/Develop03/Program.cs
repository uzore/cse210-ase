
using System;
using System.Collections.Generic;
using System.Linq;

namespace Memorizer
{

        class Program
    {
        static void Main(string[] args)
        {
            List<Word> words = new List<Word>()
            {
                new Word("And"),
                new Word("it"),
                new Word("came"),
                new Word("to"),
                new Word("pass"),
                new Word("that,"),
                new Word("I"),
                new Word("Nephi,"),
                new Word("said"),
                new Word("unto"),
                new Word("my"),
                new Word("father:"),
                new Word("I"),
                new Word("will"),
                new Word("go"),
                new Word("and"),
                new Word("do"),
                new Word("the"),
                new Word("things"),
                new Word("which"),
                new Word("the"),
                new Word("Lord"),
                new Word("hath"),
                new Word("commanded,"),
                new Word("for"),
                new Word("I"),
                new Word("know"),
                new Word("that"),
                new Word("the"),
                new Word("Lord"),
                new Word("giveth"),
                new Word("no"),
                new Word("commandments"),
                new Word("unto"),
                new Word("the"),
                new Word("children"),
                new Word("of"),
                new Word("men,"),
                new Word("save"),
                new Word("He"),
                new Word("shall"),
                new Word("prepare"),
                new Word("a"),
                new Word("way"),
                new Word("for"),
                new Word("them"),
                new Word("that"),
                new Word("they"),
                new Word("may"),
                new Word("accomplish"),
                new Word("the"),
                new Word("thing"),
                new Word("which"),
                new Word("he"),
                new Word("commandeth"),
                new Word("them."),
            };

        

            Reference reference = new Reference("1 Nephi", 3, 7, 7);

            Scripture scripture = new Scripture(reference, words);

            Console.WriteLine(scripture.reference.ToString() + " " + scripture.GetText());
            Console.WriteLine("Press enter to hide some words, or type 'quit' to exit.");

            string input = Console.ReadLine();

            while (input != "quit" && !scripture.AllWordsHidden())
            {
                
                scripture.HideRandomWords(2);
                Console.Clear();
                Console.WriteLine(scripture.reference.ToString() + " " + scripture.GetText());
                Console.WriteLine("Press enter to hide more words, or type 'quit' to exit");
            }
        }

        class Scripture
        {
            public Reference reference;
            public List<Word> words;

            public Scripture(Reference reference, List<Word> words)
            {
                this.reference = reference;
                this.words = words;
            }

            public string GetText()
            {
                string text = "";

                foreach (Word word in words)
                {
                    text += word.GetText() + " ";
                }

                return text.Trim();
            }

            public void HideRandomWords(int numToHide)
            {
                Random rand = new Random();

                for (int i = 0; i < numToHide; i++)
                {
                    int index = rand.Next(words.Count);
                    words[index].Hide();
                }
            }

            public bool AllWordsHidden()
            {
                foreach (Word word in words)
                {
                    if (!word.IsHidden())
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        class Word
        {
            private string text;
            private bool hidden;

            public Word(string text)
            {
                this.text = text;
                this.hidden = false;
            }

            public string GetText()
            {
                if (hidden)
                {
                    return "_____";
                }
                else
                {
                    return text;
                }
            }

            public void Hide()
            {
                hidden = true;
            }

            public bool IsHidden()
            {
                return hidden;
            }
        }

        class Reference
        {
            public string book;
            public int chapter;
            public int startVerse;
            public int endVerse;

            public Reference(string book, int chapter, int startVerse, int endVerse)
            {
                this.book = book;
                this.chapter = chapter;
                this.startVerse = startVerse;
                this.endVerse = endVerse;
            }

            public override string ToString()
            {
                if (startVerse == endVerse)
                {
                    return book + " " + chapter + ":" + startVerse;
                }
                else
                {
                    return book + " " + chapter + ":" + startVerse + "-" + endVerse;
                }
            }
        }
    }
}
