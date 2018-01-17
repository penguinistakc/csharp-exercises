using System;

namespace WhereIsAlice
{
    class Program
    {
        static void Main(string[] args)
        {
            string aliceExcerpt = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                                   "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                                   "but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice" +
                                   " 'without pictures or conversation?'";

            string aliceExcerptFindString = aliceExcerpt.ToLower();

            string writeLabel = "What term are you looking for? ";

            Console.WriteLine(writeLabel);

            string whereIsAlice = Console.ReadLine();

            bool isAliceHere = aliceExcerptFindString.Contains(whereIsAlice.ToLower());

            Console.WriteLine("Did I find your string? " + isAliceHere);

            Console.ReadLine();

            

            

        }
    }
}
